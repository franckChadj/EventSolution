using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSolution
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temp { get; }

        public TemperatureEventArgs(double temperature)
        {
            Temp = temperature;
        }
    }
}
