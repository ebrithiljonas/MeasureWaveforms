using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureWaveforms
{
    public class DataPoint
    {
        public Double inputFrequency { get; set; }
        public Double outputVoltage { get; set; }
        public Double inputVoltage { get; set; }
        public Double phase { get; set; }

        public DataPoint(Double X, Double Y, Double inputV, Double angle)
        {
            inputFrequency = X;
            outputVoltage = Y;
            inputVoltage = inputV;
            phase = angle;
        }

    }
}
