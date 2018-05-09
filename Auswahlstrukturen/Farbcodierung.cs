using System;
using System.Collections.Generic;
using System.Text;

namespace Auswahlstrukturen
{
    public class Farbcodierung : SchoolTask
    {
        protected Farbcodierung() : base() { }
        static Farbcodierung() { new Farbcodierung(); }
        public new static void Init() { }

        public override void RunTask()
        {
            string input = "";

            Console.WriteLine("Welches Schiff willst du Ausgeben? (1-5)");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ");
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("  ");
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("   ");
                    break;
                case "4":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("    ");
                    break;
                case "5":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("     ");
                    break;
                default:
                    Console.WriteLine("Mögliche eingaben sind die Zahlen 1-5.");
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
