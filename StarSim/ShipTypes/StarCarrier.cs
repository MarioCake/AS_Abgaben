using System;
using System.Collections.Generic;
using System.Text;

namespace StarSim.ShipTypes
{
    public class StarCarrier : Ship
    {
        public StarCarrier(Engine engine, Capitan capitan) : base(engine, capitan)
        {
        }

        public override int MaximumLoad => 250000;
    }
}
