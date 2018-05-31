using System;
using System.Collections.Generic;
using System.Text;
using static School.Helper;

namespace Entscheidungstabellen
{
    class Entscheidungstabelle : School.SchoolTask
    {
        public Entscheidungstabelle() : base("Entscheidungstabelle")
        {

        }

        protected override void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Preis der Ware ein.");
            TryRepeatedConsoleParse(out double price, "Erwarte eine Zahl größer gleich 0.", value => value >= 0);

            Console.WriteLine("Geben Sie die Anzahl der Ware ein.");
            TryRepeatedConsoleParse(out int amount, "Erwarte eine Zahl größer gleich 0.", value => value >= 0);

            double discount = 0.05d;

            if (amount >= 100)
            {
                discount = 0.2d;
            }
            else if(amount >= 50)
            {
                discount = 0.15d;
            }
            else if(amount >= 10)
            {
                discount = 0.1d;
            }

            Console.WriteLine("Anzahl der Ware: {0}", amount);
            Console.WriteLine("Preis der Ware: {0} Euro", price);
            Console.WriteLine("Rabatt: {0}%", discount * 100);
            Console.WriteLine("Preis aller Waren ohne Rabatt: {0} Euro", price * amount);
            Console.WriteLine("Preis aller Waren mit Rabatt: {0} Euro", (price * amount) * (1.0d-discount));
        }
    }
}
