using School;
using System;
using static School.Helper;

namespace Methoden
{
    public class VolumenBerechnung : SchoolTask
    {
        #region
        public VolumenBerechnung() : base("Volumenberechnung") { }
        #endregion

        private static void Würfel()
        {
            Console.WriteLine("Geben Sie eine Seitenlänge a ein:");
            TryRepeatedConsoleParse(out double sideLength, errorMessage: "Übgültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Das Volumen eines Würfels der Seitenlänge a = {0}cm liegt bei {1}cm^3.", sideLength, Math.Pow(sideLength, 3));
        }

        private static void Quader()
        {
            Console.WriteLine("Geben Sie die Seitenlänge a ein:");
            TryRepeatedConsoleParse(out double a, errorMessage: "Übgültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Geben Sie die Seitenlänge b ein:");
            TryRepeatedConsoleParse(out double b, errorMessage: "Übgültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Geben Sie die Seitenlänge c ein:");
            TryRepeatedConsoleParse(out double c, errorMessage: "Übgültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Das Volumen eines Quaders mit den Seitenlängen a = {0}cm, b = {1}cm und c = {2}cm ist {3}cm^3", a, b, c, a * b * c);

        }

        private static void Zylinder()
        {
            Console.WriteLine("Geben Sie den Radius r ein: ");
            TryRepeatedConsoleParse(out double radius, errorMessage: "Ungültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Geben Sie eine Höhe h ein: ");
            TryRepeatedConsoleParse(out double height, errorMessage: "Ungültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Das Volumen eines Zylinders mit derm Radius r = {0}cm und der Höhe h = {1}cm ist {2}cm^3", radius, height, radius * radius * Math.PI * height);
        }

        private static void Pyramide()
        {
            Console.WriteLine("Geben Sie die Seitenlänge a der Grundfläche ein: ");
            TryRepeatedConsoleParse(out double a, errorMessage: "Ungültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Geben Sie die Höhe h der Pyramide auf: ");
            TryRepeatedConsoleParse(out double height, errorMessage: "Ungültige Eingabe. Erwarte eine Zahl.");

            Console.WriteLine("Das Volumen eine Pyramide mit einer Grundfläche der Seitenlänge a = {0}cm und der Höhe h = {1}cm ist {2}cm^3", a, height, 1d / 3d * a * a * height);
        }


        protected override void Main(string[] args)
        {
            Console.WriteLine("Was möchtest du berechnen?");

            Console.WriteLine("Würfel:\t\t1)");
            Console.WriteLine("Quader:\t\t2)");
            Console.WriteLine("Zylinder:\t3)");
            Console.WriteLine("Pyramide:\t4)");
            
            TryRepeatedConsoleParse(out int program, validationFunction: input => input > 1 || input <= 4, errorMessage: "Ungültige Eingabe. Geben Sie bitte eine der oben genannten Zahlen ein.");


            switch (program)
            {
                case 1:
                    Würfel();
                    break;
                case 2:
                    Quader();
                    break;
                case 3:
                    Zylinder();
                    break;
                case 4:
                    Pyramide();
                    break;
            }

        }

    }
}
