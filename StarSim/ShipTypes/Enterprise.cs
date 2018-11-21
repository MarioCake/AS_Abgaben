using System;
using System.Collections.Generic;
using System.Text;

namespace StarSim.ShipTypes
{
    public class Enterprise : Ship
    {
        public Enterprise(Engine engine, Capitan capitan) : base(engine, capitan)
        {
        }

        public override int MaximumLoad => 750000;
    }
}
