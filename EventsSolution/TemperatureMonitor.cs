using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsSolution
{
    public class TemperatureMonitor
    {
        // Delegate for the event
        public delegate void TemperatureChangedEventHandler(object sender, TemperatureEventArgs e);

        // Event declaration
        public event TemperatureChangedEventHandler TemperatureChanged;

        // Simulate temperature changes (for demonstration purposes)
        public void SimulateTemperatureChange(double newTemperature)
        {
            if (TemperatureChanged != null)
            {
                var args = new TemperatureEventArgs(newTemperature);
                TemperatureChanged(this, args);
            }
        }
    }
}
