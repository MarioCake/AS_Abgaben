using System;
using System.Collections.Generic;
using System.Text;

namespace StarSim
{
    public class Capitan
    {
        public string Name { get; set; }
        public string Rang { get; set; }

        public Capitan(string name, string rang)
        {
            Name = name;
            Rang = rang;
        }

        public override string ToString()
        {
            return string.Format("Capitan: {0}, Rang: {1}", Name, Rang);
        }
    }
}
