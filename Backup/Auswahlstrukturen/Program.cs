using System;
using System.Linq;

namespace Auswahlstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            Farbcodierung.Init();
            MiniSchiffeVersenken.Init();
            Funktionsloeser.Init();
            OhmschesGesetz.Init();

            Console.WriteLine("Welche Anwendung möchtest du starten?" + Environment.NewLine);
            for (int i = 0; i < SchoolTask.AllSchoolTasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + SchoolTask.AllSchoolTasks[i].GetType().Name);
            }

            int taskNumber;

            Console.Write("Anwendung: ");
            while (!int.TryParse(Console.ReadLine(), out taskNumber) || taskNumber <= 0 || taskNumber > SchoolTask.AllSchoolTasks.Count)
            {
                Console.WriteLine("Das ist keine valide Nummer für eine Anwendung. Wählen sie eines der oben genannten zahlen aus!");
                Console.Write("Anwendung: ");
            }

            taskNumber--;

            Console.Clear();
            SchoolTask.AllSchoolTasks[taskNumber].RunTask();

            Console.WriteLine();
            Console.WriteLine("Drücken sie eine beliebige Taste um die Anwendung zu beenden...");
            Console.ReadKey();
        }
    }
}
