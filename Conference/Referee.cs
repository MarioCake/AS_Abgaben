using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference
{
    public class Referee
    {
        public string Name { get; private set; }
        public string Company { get; private set; }

        public Tutorial RefereeingTutorial { get; private set; }

        private readonly List<Tutorial> watchingTutorials;
        public IReadOnlyList<Tutorial> WatchingTutorials { get => watchingTutorials; }

        public Referee(string name, string company)
        {
            Name = name;
            Company = company;
        }

        public void RefereeTutorial(Tutorial tutorial)
        {
            if (tutorial == null)
            {
                throw new ArgumentNullException(nameof(tutorial));
            }

            if (RefereeingTutorial != tutorial)
            {
                RefereeingTutorial.RefereedBy(null);
                RefereeingTutorial = tutorial;
                RefereeingTutorial.RefereedBy(this);
            }
        }

        public void Watch(Tutorial tutorial)
        {
            if (WatchingTutorials.All(watchingTutorial => watchingTutorial == tutorial))
            {
                watchingTutorials.Add(tutorial);
                tutorial.WatchedBy(this);
            }
        }
    }
}
