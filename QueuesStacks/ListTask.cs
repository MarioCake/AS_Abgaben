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

        private static void PrintList(List<int> myList)
        {
            int index = 0;
            myList.ForEach(value => Console.WriteLine("myList[{0}] : {1}", (index++).ToString().PadLeft(2), value));
        }

        protected override void Main(string[] args)
        {
            Random random = new Random();
            List<int> myList = Enumerable.Range(0, 20).Select(i => random.Next(9)+1).ToList();
            Console.WriteLine("Ausgabe: Liste 20 Zufallszahlen");

            PrintList(myList);

            Console.Write(Environment.NewLine + "Eine Zahl zwischen 1 und 9: ");
            TryRepeatedConsoleParse(out int searchNumber, "Erwarte eine Zahl zwischen 1 und 9 inklusive", input => input >= 1 && input <= 9);


            int amountNumber = myList.Count(value => value == searchNumber);
            List<int> indices = Enumerable.Range(0, myList.Count).Where(i => myList[i] == searchNumber).ToList();
            Console.WriteLine("Die Zahl {0} kommt {1} mal in der Liste vor.", searchNumber, amountNumber);

            Console.WriteLine(Environment.NewLine + "Die Zahl kommt an folgenden Indizes in der Liste vor:");
            indices.ForEach(value => Console.WriteLine("myList[{0}] : {1}", value.ToString().PadLeft(2), searchNumber));

            myList.RemoveAll(value => value == searchNumber);
            Console.WriteLine(Environment.NewLine + "Liste nach Löschung von {0}:", searchNumber);
            PrintList(myList);

            Console.WriteLine(Environment.NewLine + "Liste nach Einfuegen von 0 hinter jeder 5");
            for(int i = myList.Count-1; i >= 0; i--)
            {
                if (myList[i] == 5)
                    myList.Insert(i+1, 0);
            }

            PrintList(myList);

        }
    }
}
