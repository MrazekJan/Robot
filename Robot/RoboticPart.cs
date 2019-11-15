using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    class RoboticPart
    {
        public virtual string StatusMessage { get { return "This is robotic part"; } }
        public double Consumption { get { return DeviceConsumption; } }
        public virtual double DeviceConsumption { get; protected set; }

    }
}
