using System;
using System.Collections.Generic;
using System.Text;

namespace MethodenErstellung
{
    public class Preismodul : School.SchoolTask
    {
        public Preismodul(): base("Preismodul") { }

        // Methodendefinition
        public static void Programmhinweis() // Methodenkopf
        { // Methodenrumpf Beginn

                 // Methodenaufruf
            Console.WriteLine(/* Argument */"Hinweis: ");

                 // Methodenaufruf
            Console.WriteLine(/* Argument */"Das Programm addiert 2 eingegebene Zahlen. ");

        } // Methodenrumpf Ende

        // Methodendefinition
        public static void Ausgabe(/* Parameter */double erg, /* Parameter */double zahl1, /* Parameter */double zahl2) // Methodenkopf
        { // Methodenrumpf Beginn

                 // Methodenaufruf
            Console.WriteLine(/* Argument */"Ergebnis der Addition");

                 // Methodenaufruf
            Console.WriteLine(/* Argument */ erg + " = " + zahl1 + " + " + zahl2);

        } // Methodenrumpf Ende

        // Methodendefinition
        public static /* Rückgabedatentyp */double Verarbeitung(/* Parameter */double zahl1, /* Parameter */ double zahl2) // Methodenkopf
        { // Methodenrumpf Beginn

            return /* Rückgabewert */ zahl1 + zahl2;

        } // Methodenrumpf Ende


        // Methodendefinition
        public static /* Rückgabedatentyp */(double, double) Eingabe() // Methodenkopf
        { // Methodenrumpf Beginn

                 // Methodenaufruf
            Console.WriteLine(" 1. Zahl:");

                               // Methodenaufruf              Methodenaufruf
            double zahl1 = double.Parse(/* Argument */Console.ReadLine());

                 // Methodenaufruf
            Console.WriteLine(/* Argument */" 2. Zahl:");

            // Methodenaufruf
            double zahl2 = double.Parse(/* Argument */Console.ReadLine());

            return /* Rückgabewert */ (zahl1, zahl2);
        } // Methodenrumpf Ende

        protected override void Main(string[] args)
        {
            // Methodenaufruf
            Programmhinweis();
                                        // Methodenaufruf
            (double zahl1, double zahl2) = Eingabe();

                            // Methodenaufruf
            double ergebnis = Verarbeitung(/* Argument */zahl1, /* Argument */zahl2);

            // Methodenaufruf
            Ausgabe(/* Argument */ergebnis, /* Argument */zahl1, /* Argument */zahl2);
        }
    }
}
