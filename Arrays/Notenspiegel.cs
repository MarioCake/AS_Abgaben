using System;
using System.Collections.Generic;
using System.Text;
using static School.Helper;
using static System.Environment;
namespace Arrays
{
    class Notenspiegel : School.SchoolTask
    {
        #region
        public Notenspiegel() : base("Notenspiegel") { }
        #endregion

        protected override void Main(string[] args)
        {
            Console.WriteLine("Noteneingabe: {0}", NewLine);

            int amount = 6;

            int[] notenspiegel = GetArrayOf<int>(amount, (currentIndex, lastValue) =>
            {
                Console.Write("Anzahl der Schueler mit Note {0}: ", currentIndex + 1);
                return true;
            }, validationFunction: value => value >= 0, errorMessage: "Ungültige Eingabe. Erwarte eine Zahl größer gleich 0");

            Console.Write("{0}Notenspiegel{0}  Note:\t", NewLine);
            for(int i = 0; i < notenspiegel.Length; i++)
            {
                Console.Write("\t{0}", i+1);
            }

            Console.Write("{0}Anzahl:\t", NewLine);

            int summeNotenpunkte = 0;
            int summeNotenanzahl = 0;
            for(int i = 0; i < notenspiegel.Length; i++)
            {
                Console.Write("\t{0}", notenspiegel[i]);
                summeNotenanzahl += notenspiegel[i];
                summeNotenpunkte += notenspiegel[i] * (i + 1);
            }
            double varianzSumme = 0;

            double notendurchschnitt = 1d * summeNotenpunkte / summeNotenanzahl;
            foreach (int note in notenspiegel)
            {
                varianzSumme += Math.Pow(note - notendurchschnitt, 2);
            }
            double standardAbweichung = Math.Sqrt(varianzSumme / summeNotenanzahl);

            Console.WriteLine("{0}{0}Notendurchschnitt: \t{1}", NewLine, notendurchschnitt);
            Console.WriteLine("Standardabweichung: \t{0}", standardAbweichung);


        }
    }
}
