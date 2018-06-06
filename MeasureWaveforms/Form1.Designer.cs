namespace MeasureWaveforms
{
    partial class MeasureWaveforms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasureWaveforms));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnectDSO = new System.Windows.Forms.Button();
            this.tbDSOAdress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFGenConnect = new System.Windows.Forms.Button();
            this.tbFGenAdress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.chartWaveform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spFGen = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nupDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupSteps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupStopF = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nupStartF = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbOutputF = new System.Windows.Forms.Label();
            this.lbInputF = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStopF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStartF)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnConnectDSO);
            this.groupBox1.Controls.Add(this.tbDSOAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DSO Address";
            // 
            // btnConnectDSO
            // 
            this.btnConnectDSO.Location = new System.Drawing.Point(315, 18);
            this.btnConnectDSO.Name = "btnConnectDSO";
            this.btnConnectDSO.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDSO.TabIndex = 1;
            this.btnConnectDSO.Text = "Connect";
            this.btnConnectDSO.UseVisualStyleBackColor = true;
            this.btnConnectDSO.Click += new System.EventHandler(this.btnConnectDSO_Click);
            // 
            // tbDSOAdress
            // 
            this.tbDSOAdress.Location = new System.Drawing.Point(6, 19);
            this.tbDSOAdress.Name = "tbDSOAdress";
            this.tbDSOAdress.Size = new System.Drawing.Size(303, 20);
            this.tbDSOAdress.TabIndex = 0;
            this.tbDSOAdress.Text = "TCPIP0::oscesa226::INSTR";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFGenConnect);
            this.groupBox2.Controls.Add(this.tbFGenAdress);
            this.groupBox2.Location = new System.Drawing.Point(414, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funtion Generator Address";
            // 
            // btnFGenConnect
            // 
            this.btnFGenConnect.Location = new System.Drawing.Point(151, 18);
            this.btnFGenConnect.Name = "btnFGenConnect";
            this.btnFGenConnect.Size = new System.Drawing.Size(75, 23);
            this.btnFGenConnect.TabIndex = 1;
            this.btnFGenConnect.Text = "Connect";
            this.btnFGenConnect.UseVisualStyleBackColor = true;
            this.btnFGenConnect.Click += new System.EventHandler(this.btnFGenConnect_Click);
            // 
            // tbFGenAdress
            // 
            this.tbFGenAdress.Location = new System.Drawing.Point(6, 19);
            this.tbFGenAdress.Name = "tbFGenAdress";
            this.tbFGenAdress.Size = new System.Drawing.Size(139, 20);
            this.tbFGenAdress.TabIndex = 0;
            this.tbFGenAdress.Text = "COM1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnExportCSV);
            this.groupBox3.Location = new System.Drawing.Point(652, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(6, 16);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportCSV.TabIndex = 4;
            this.btnExportCSV.Text = "Excel";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // chartWaveform
            // 
            this.chartWaveform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Input Frequency [Hz]";
            chartArea1.AxisY.Title = "VPP [V]";
            chartArea1.Name = "ChartArea1";
            this.chartWaveform.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWaveform.Legends.Add(legend1);
            this.chartWaveform.Location = new System.Drawing.Point(12, 70);
            this.chartWaveform.Name = "chartWaveform";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWaveform.Series.Add(series1);
            this.chartWaveform.Size = new System.Drawing.Size(729, 342);
            this.chartWaveform.TabIndex = 4;
            this.chartWaveform.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.nupDelay);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nupSteps);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nupStopF);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nupStartF);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 68);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // nupDelay
            // 
            this.nupDelay.Location = new System.Drawing.Point(312, 37);
            this.nupDelay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupDelay.Name = "nupDelay";
            this.nupDelay.Size = new System.Drawing.Size(74, 20);
            this.nupDelay.TabIndex = 9;
            this.nupDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay [ms]:";
            // 
            // nupSteps
            // 
            this.nupSteps.Location = new System.Drawing.Point(232, 37);
            this.nupSteps.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupSteps.Name = "nupSteps";
            this.nupSteps.Size = new System.Drawing.Size(74, 20);
            this.nupSteps.TabIndex = 7;
            this.nupSteps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Steps [Hz]:";
            // 
            // nupStopF
            // 
            this.nupStopF.Location = new System.Drawing.Point(122, 37);
            this.nupStopF.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupStopF.Name = "nupStopF";
            this.nupStopF.Size = new System.Drawing.Size(101, 20);
            this.nupStopF.TabIndex = 5;
            this.nupStopF.Value = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Frequency [Hz]:";
            // 
            // nupStartF
            // 
            this.nupStartF.Location = new System.Drawing.Point(9, 37);
            this.nupStartF.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupStartF.Name = "nupStartF";
            this.nupStartF.Size = new System.Drawing.Size(104, 20);
            this.nupStartF.TabIndex = 3;
            this.nupStartF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Frequency [Hz]:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btClear);
            this.groupBox5.Controls.Add(this.btStop);
            this.groupBox5.Controls.Add(this.btStart);
            this.groupBox5.Location = new System.Drawing.Point(414, 418);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 68);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(216, 21);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(103, 36);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear Data";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(111, 21);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(99, 36);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop Mesurment";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(6, 21);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(99, 36);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start Mesurment";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbOutputF);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 52);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Frequency [Hz]";
            // 
            // lbOutputF
            // 
            this.lbOutputF.AutoSize = true;
            this.lbOutputF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutputF.Location = new System.Drawing.Point(6, 16);
            this.lbOutputF.Name = "lbOutputF";
            this.lbOutputF.Size = new System.Drawing.Size(24, 25);
            this.lbOutputF.TabIndex = 0;
            this.lbOutputF.Text = "0";
            // 
            // lbInputF
            // 
            this.lbInputF.AutoSize = true;
            this.lbInputF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputF.Location = new System.Drawing.Point(6, 16);
            this.lbInputF.Name = "lbInputF";
            this.lbInputF.Size = new System.Drawing.Size(54, 25);
            this.lbInputF.TabIndex = 0;
            this.lbInputF.Text = "0.00";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lbInputF);
            this.groupBox7.Location = new System.Drawing.Point(466, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(275, 52);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Voltage Peak Peak [V]";
            // 
            // MeasureWaveforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 550);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chartWaveform);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(774, 240);
            this.Name = "MeasureWaveforms";
            this.Text = "MeasureWaveforms";
            this.Load += new System.EventHandler(this.MeasureWaveforms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWaveform)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStopF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStartF)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnectDSO;
        private System.Windows.Forms.TextBox tbDSOAdress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFGenConnect;
        private System.Windows.Forms.TextBox tbFGenAdress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWaveform;
        private System.IO.Ports.SerialPort spFGen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nupStopF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupStartF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupSteps;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbOutputF;
        private System.Windows.Forms.Label lbInputF;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

