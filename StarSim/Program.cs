using StarSim.EngineTypes;
using StarSim.LoadTypes;
using StarSim.ShipTypes;
using System;
using System.Collections.Generic;

namespace StarSim
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Load> funterpriseLoad = new List<Load>
            {
                new Food("Cake", 10000),
                new Food("Gummybears", 50000),
                new Scrap("Brocoli", 5),
                new Scrap("Spinach", 10),
                new ToolMaterial("Condoms", 10000)
            };

            Ship funterprise = new Enterprise(new Sol8(), new Capitan("Helene Fisher", "Singer"));
            funterprise.AddLoad(funterpriseLoad);

            List<Load> boringCarrierLoad = new List<Load>
            {
                new ToolMaterial("Steel", 25000),
                new Food("Brocoli", 100000),
                new Fuel("Stardustpowder", 100000)
            };

            Ship boringCarrier = new StarCarrier(new Warp4(), new Capitan("Patrick Fiedler", "Lehrer"));
            boringCarrier.AddLoad(boringCarrierLoad);

            if(!funterprise.TransferLoad(boringCarrier, funterprise.Load[1]))
            {
                Console.WriteLine(string.Format("Unable to transfer {0} to boringCarrier", funterprise.Load[1]));
            }

            Console.WriteLine(funterprise);
            Console.WriteLine(boringCarrier);

        }
    }
}
