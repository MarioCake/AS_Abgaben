using System;
using System.Collections.Generic;
using System.Text;

namespace Auswahlstrukturen
{
    public class Funktionsloeser : SchoolTask
    {
        protected Funktionsloeser() : base() { }
        static Funktionsloeser() { new Funktionsloeser(); }
        public new static void Init() { }

        public override void RunTask()
        {
            Console.Write("Geben Sie einen Funktionsparameter x ein: ");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                if(x <= 0)
                    Console.WriteLine("(x <= 0) Exponentielle Funktion f(x) = e^x = " + Math.Exp(x));
                else if(x <= 3)
                    Console.WriteLine("(0 < x <= 3) Quadratische Funktion f(x) = x^2 + 1 = " + (x * x + 1));
                else
                    Console.WriteLine("(x > 3) Lineare Funktion f(x) = 2*x + 4 = " + (2 * x + 4));
            }
            else
            {
                Console.WriteLine("Geben Sie bitte eine Zahl ein!");
            }
        }
    }
}
