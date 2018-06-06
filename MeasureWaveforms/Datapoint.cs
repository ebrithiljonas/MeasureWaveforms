using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureWaveforms
{
    public class DataPoint
    {
        public double inputFrequency { get; set; }
        public double outputFrequency { get; set; }

        public DataPoint(Double X, Double Y)
        {
            inputFrequency = X;
            outputFrequency = Y;
        }

    }
}
