using System;

namespace Conference
{
    public class Registration
    {

        public Participant Participant { get; private set; }
        public Tutorial Tutorial { get; private set; }
        public DateTime RegitrationDate { get; private set; }
        public bool Paid { get; private set; }

        public Registration(Participant participant, Tutorial tutorial)
        {
            RegitrationDate = DateTime.Now;
            Participant = participant;
            Tutorial = tutorial;
        }

        public void PayBy(Participant participant)
        {
            if (!Paid)
            {
                Paid = true;
            }
        }
    }
}
