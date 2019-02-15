using System;
using System.Collections.Generic;
using Fußballvereinsverwaltung;

namespace Vereinsverwaltung
{
    public class Team
    {
        private HashSet<Fußballer> _mannschaft = new HashSet<Fußballer>(11);
        public IEnumerable<Fußballer> Mannschaft { get { return _mannschaft; } }
        public int GeschosseneTore { get; set; }

        private Kapitän _kapitän;
        public Kapitän Kapitän
        {
            get { return _kapitän; }
            set
            {
                if (_kapitän != null)
                {
                    _kapitän.Team = null;
                }
                _kapitän = value;

                if (_kapitän != null)
                {
                    _kapitän.Team = this;
                }
            }
        }

        private Trainer _trainer;
        public Trainer Trainer
        {
            get { return _trainer; }
            set
            {
                if (_trainer != null)
                {
                    _trainer.Team = null;
                }
                _trainer = value;

                if (_trainer != null)
                {
                    _trainer.Team = this;
                }
            }
        }
        public int Siege { get; set; }

        public void Add(Fußballer fußballer)
        {
            if (fußballer == null)
                throw new ArgumentNullException(nameof(fußballer));

            if (fußballer.Team != null)
            {
                fußballer.Team = null;
            }

            _mannschaft.Add(fußballer);
        }

        public void Remove(Fußballer fußballer)
        {
            if (fußballer == null || !_mannschaft.Contains(fußballer))
                return;

            if(fußballer.Team == this)
            {
                fußballer.Team = null;
            }

            _mannschaft.Remove(fußballer);
        }
    }
}
