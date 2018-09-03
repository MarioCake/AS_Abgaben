using System;
using System.Collections.Generic;
using System.Text;

namespace Auswahlstrukturen
{
    public class MiniSchiffeVersenken : SchoolTask
    {
        protected MiniSchiffeVersenken() : base() { }
        static MiniSchiffeVersenken() { new MiniSchiffeVersenken(); }
        public new static void Init() { }

        public override void RunTask()
        {
            Random rand = new Random();

            int x = 0,
                y = 0,
                z = 0;

            switch (rand.Next(3))
            {
                case 0:
                    x = 1;
                    break;
                case 1:
                    y = 1;
                    break;
                case 2:
                    z = 1;
                    break;
            }

            Console.WriteLine("Welche Zahl ist 1? x, y oder z?");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case nameof(x):
                    if (x == 1) Console.WriteLine("Richtig geraten!");
                    else Console.WriteLine("Falsch geraten!");
                    break;
                case nameof(y):
                    if (y == 1) Console.WriteLine("Richtig geraten!");
                    else Console.WriteLine("Falsch geraten!");
                    break;
                case nameof(z):
                    if (z == 1) Console.WriteLine("Richtig geraten!");
                    else Console.WriteLine("Falsch geraten!");
                    break;
                default:
                    Console.WriteLine("Fehler! Die Eingabe muss entweder x, y oder z sein!");
                    break;
            }
        }
    }
}
