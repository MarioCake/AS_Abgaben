using School;
using System;
using static School.Helper;

namespace Methoden
{
    public class MethodenEva : SchoolTask
    {
        #region
        public MethodenEva() : base("EVA Methoden") { }
        #endregion

        
        private static (double kathete1, double kathete2) Eingabe()
        {
            Console.WriteLine("Geben Sie die Länge der ersten Kathete ein:");
            TryRepeatedConsoleParse(out double kathete1, errorMessage: "Geben Sie bitte eine Zahl ein!");


            Console.WriteLine("Geben Sie die Länge der zweiten Kathete ein:");
            TryRepeatedConsoleParse(out double kathete2, errorMessage: "Geben Sie bitte eine Zahl ein!");


            return (kathete1, kathete2);
        }

        private static double Verarbeitung(double kathete1, double kathete2)
        {
            return Math.Sqrt(kathete1 * kathete1 + kathete2 + kathete2);
        }
        
        private static void Ausgabe(double hypotenuse)
        {
            Console.WriteLine("Die Länge der Hypotenuse ist " + hypotenuse);
        }

        protected override void Main(string[] args)
        {
            (double kathete1, double kathete2) = Eingabe();
            double hypothenuse = Verarbeitung(kathete1, kathete2);
            Ausgabe(hypothenuse);

        }

    }
}
