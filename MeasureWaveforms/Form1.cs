using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ivi.Visa.Interop;
using Microsoft.Office.Interop.Excel;

namespace MeasureWaveforms
{
    public partial class MeasureWaveforms : Form
    {
        public MeasureWaveforms()
        {
            InitializeComponent();

            chartWaveform.DataSource = Datapoints;

            chartWaveform.Series[0].XValueMember = "inputFrequency";
            chartWaveform.Series[0].YValueMembers = "outputFrequency";
            chartWaveform.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartWaveform.Series[0].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartWaveform.DataBind();

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (spFGen.IsOpen) spFGen.Close();
        }

        ResourceManager rm = new ResourceManager();
        FormattedIO488 instrument = new FormattedIO488();

        private void btnConnectDSO_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a connection to the instrument and bind 
                // it to the formatter. 
                instrument.IO = (IMessage)rm.Open(tbDSOAdress.Text,
                    AccessMode.NO_LOCK, 0, "");

                // Socket connections don't automatically add a
                // termination character so enable it in the interface.
                instrument.IO.TerminationCharacterEnabled = true;

                // There are other useful settings as well like setting 
                // the VISA timeout in miliseconds
                instrument.IO.Timeout = 3000;

                try
                {

                    string idnResult = "";
                    //Send the *IDN? query SCPI command to the instrument
                    instrument.WriteString("*IDN?", true);

                    //Reading IDN string response from the instrument 
                    idnResult = instrument.ReadString();
                    //MessageBox.Show("Instrument *IDN? query returned: \n" + idnResult);

                    groupBox1.ForeColor = Color.Green;

                }
                catch  (Exception)
                {
                    groupBox1.ForeColor = Color.Red;
                    MessageBox.Show("Connection Failed!");
                }

            }
            catch (Exception)
            {
                groupBox1.ForeColor = Color.Red;
            }
        }

        private void btnFGenConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFGenAdress.Text != "")
                {
                    spFGen.PortName = tbFGenAdress.Text;
                    spFGen.Open();
                    groupBox2.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                groupBox2.ForeColor = Color.Red;
            }
            
        }

        private void sendFGenCommand(String command)
        {
            if(spFGen.IsOpen)
            {
                spFGen.WriteLine(command);
            }
        }

        List<DataPoint> Datapoints = new List<DataPoint>();

        private void addDatapoint(Double X, Double Y)
        {

            DataPoint d = new DataPoint(X,Y);
            Datapoints.Add(d);
            chartWaveform.DataBind();

        }

        private long startF, endF;
        private Double frequency;
        private Workbook xlWorkBook;

        private void btStart_Click(object sender, EventArgs e)
        {
            startF = (long)nupStartF.Value;
            endF = (long)nupStopF.Value;
            frequency = startF;

            setFrequency(frequency);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Double f = getFrequency();
            addDatapoint(frequency, f);
            lbInputF.Text = f.ToString("N2");
            lbOutputF.Text = frequency.ToString("G");
            if (frequency >= endF)
            {
                timer1.Stop();

            }
            else
            {
                frequency += (long)nupSteps.Value;
                setFrequency(frequency);
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Datapoints.Clear();
            chartWaveform.DataBind();
        }

        private void setFrequency(Double F)
        {
            String msg = "FREQ " + F.ToString();
            sendFGenCommand(msg);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {

            exportExcel();

        }

        private void exportCSV()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = ".csv";
            savefile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            StringBuilder csv = new StringBuilder();

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String name = System.IO.Path.GetFileNameWithoutExtension(savefile.FileName);

                csv.AppendLine(name);
                csv.AppendLine("\"Frequency [Hz]\",\"VPP [V]\"");

                foreach (DataPoint p in Datapoints)
                {
                    String X = p.inputFrequency.ToString("G");
                    String Y = p.outputFrequency.ToString("N4");

                    String s = string.Format("{0},{1}", X, Y);

                    csv.AppendLine(s);
                }

                try
                {
                    System.IO.File.WriteAllText(savefile.FileName, csv.ToString());
                }
                catch (Exception)
                {
                    throw;
                }

            }

        }

        private void exportExcel()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = ".xlsx";
            savefile.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String name = System.IO.Path.GetFileNameWithoutExtension(savefile.FileName);

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Cells[1, 1] = name;
                xlWorkSheet.Cells[2, 1] = "Frequency [Hz]";
                xlWorkSheet.Cells[2, 2] = "VPP [V]";
                int count = 3;
                foreach (DataPoint p in Datapoints)
                {
                    String X = p.inputFrequency.ToString("G");
                    String Y = p.outputFrequency.ToString("N4");
                    xlWorkSheet.Cells[count, 1] = X;
                    xlWorkSheet.Cells[count, 2] = Y;
                }

                xlWorkBook.SaveAs(savefile.FileName);

                xlWorkBook.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setFrequency(100);
        }

        private void MeasureWaveforms_Load(object sender, EventArgs e)
        {

        }

        private Double getFrequency()
        {
            Double F = 0;

            instrument.WriteString("MEASure:SOURce CHANnel1");
            instrument.WriteString(":MEASure:VPP?");
            F = instrument.ReadNumber();
            return F;
        }
    }
}
