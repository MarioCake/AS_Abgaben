using School;
using System;
using System.Collections.Generic;
using System.Text;
using static School.Helper;

namespace Methoden
{
    class ArithmetischerMittel : SchoolTask
    {
        public ArithmetischerMittel() : base("Arithmetisches Mittel") { }

        protected override void Main(string[] args)
        {
            Console.WriteLine("Geben Sie alle Zahlen an, aus welchem Sie das Mittel berechnen wollen. Beenden Sie mit 0.");

            double number;
            int count = 0;
            double sum = 0;
            do
            {
                count++;
                TryRepeatedConsoleParse(out number, errorMessage: "Ungültige Eingabe. Geben Sie eine Zahl ein.");
                Console.WriteLine("Eingabe: {0}", number);
                sum += number;
            } while (number != 0);

            Console.WriteLine("Arithmetisches Mittel aller Eingaben: {0}", sum / (count-1));
        }
    }
}
