using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    class Hangar
    {
        public Hangar()
        {
            Storage = new List<RoboticPart>();
            Storage.Add(new RoboticChasis());
        }
        public List<RoboticPart> Storage { get; set; }
    }
}
