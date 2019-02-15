using System;

namespace Conference
{
    public class FrameProgram
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public string Time { get; private set; }
        public string City { get; private set; }
        public double Costs { get; private set; }

        public FrameProgram(string name, DateTime date, string time, string city, double costs)
        {
            Name = name;
            Date = date;
            Time = time;
            City = city;
            Costs = costs;
        }
    }
}
