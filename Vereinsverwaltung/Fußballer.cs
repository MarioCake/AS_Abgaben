using System;
using Vereinsverwaltung;

namespace Fußballvereinsverwaltung
{
    public class Fußballer : Person
    {
        public int SpielerNummer { get; set; }
        public int Tore { get; set; }

        private Team _team;
        public Team Team {
            get
            {
                return _team;
            }
            set
            {
                if(value == null)
                {
                    _team.Remove(this);
                }
                _team = value;
                _team.Add(this);
            }
        }
        public double TorschussWahrscheinlichkeit { get; set; }

        private static Random _random = new Random();
        virtual public bool VersucheTorschuss()
        {
            bool treffer = _random.NextDouble() <= TorschussWahrscheinlichkeit;

            if (treffer)
            {
                Tore++;
                Team.GeschosseneTore++;
            }

            return treffer;
        }
    }
}
