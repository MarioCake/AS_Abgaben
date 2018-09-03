using System;
using System.Collections.Generic;
using System.Text;

namespace MethodenErstellung
{
    public class MethodenArrays : School.SchoolTask
    {
        public MethodenArrays(): base("Methoden und Arrays") { }

        protected override void Main(string[] args)
        {
            const int ANZ = 5;
            double[] flugpreise = new double[ANZ];
            double mittelpreis = 0.0;

            flugpreise = Eingabe(ANZ);
            mittelpreis = Durchschnittrechnung(flugpreise, ANZ);

            for (int i = 0; i < ANZ; i++)
            {
                Console.WriteLine((i + 1) + ". Preis lautet: " + flugpreise[i] + " Euro");
            }
            Console.WriteLine("Durchschnittspreis:" + mittelpreis + " Euro");
        }

        public static double[] Eingabe(int anz)
        {
            double[] fpreise = new double[anz];
            for (int i = 0; i < anz; i++)
            {
                Console.Write((i + 1) + ". Preis bitte eingeben: ");
                fpreise[i] = double.Parse(Console.ReadLine());

            }
            return fpreise;
        }

        public static double Durchschnittrechnung(double[] preise, int anz)

        {
            double durchschnitt = 0.0;
            for (int i = 0; i < anz; i++)
            {
                durchschnitt = durchschnitt + preise[i];
            }
            durchschnitt = durchschnitt / anz;
            return durchschnitt;
        }
    }
}
