using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static School.Helper;

namespace QueuesStacks
{
    class ListTask : School.SchoolTask
    {
        #region
        public ListTask() : base("Listen Aufgabe") { }
        #endregion

        protected override void Main(string[] args)
        {
            Random random = new Random();
            List<int> myList = Enumerable.Range(0, 20).Select(i => random.Next(9)+1).ToList();
            Console.WriteLine("Ausgabe: Liste 20 Zufallszahlen");
            int index = 0;
            myList.ForEach(value => Console.WriteLine("myList[{0}] : {1}", index++, value));

            Console.Write("Eine Zahl zwischen 1 und 9: ");
            TryRepeatedConsoleParse(out int searchNumber, "Erwarte eine Zahl zwischen 1 und 9 inklusive", input => input >= 1 && input <= 9);

            int amountNumber = myList.Count(value => value == searchNumber);
            List<int> indices = Enumerable.Range(0, myList.Count).Where(i => myList[i] == searchNumber).ToList();


        }
    }
}
