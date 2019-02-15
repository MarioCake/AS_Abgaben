using System;
using System.Collections.Generic;
using System.Linq;

namespace Conference
{
    public class Tutorial
    {
        private static int amountOfTutorials = 0;

        public int Number { get; private set; }
        public float Fee { get; private set; }
        public DateTime Date { get; private set; }
        public string Name { get; private set; }

        public readonly List<Referee> listeningsReferees;
        private readonly List<Registration> registrations;
        public IReadOnlyList<Registration> Registrations { get => registrations; }
        public IReadOnlyList<Referee> ListeningReferees { get => listeningsReferees; }

        public Referee Referee { get; private set; }

        public Tutorial()
        {
            registrations = new List<Registration>();
            listeningsReferees = new List<Referee>();
            Number = ++amountOfTutorials;
        }

        public void WatchedBy(Referee referee)
        {
            if(ListeningReferees.All(listeningReferee => listeningReferee != referee))
            {
                listeningsReferees.Add(referee);
                referee.Watch(this);
            }
        }

        public void Register(Participant participant)
        {
            registrations.Add(new Registration(participant, this));
        }

        public void RefereedBy(Referee referee)
        {
            if (Referee != referee)
            {
                Referee = referee;
                if (Referee != null)
                {
                    Referee.RefereeTutorial(this);
                }
            }

        }

        
        
    }
}
