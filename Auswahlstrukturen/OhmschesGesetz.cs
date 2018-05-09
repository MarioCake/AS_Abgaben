using System;
using System.Collections.Generic;
using System.Text;

namespace Auswahlstrukturen
{
    public class OhmschesGesetz : SchoolTask
    {
        protected OhmschesGesetz() : base() { }
        static OhmschesGesetz() { new OhmschesGesetz(); }
        public new static void Init() { }

        public override void RunTask()
        {
            Console.WriteLine("Geben Sie 2 Werte aus dem Ohmschen Gesetz an in diesem Stil: U = 5. Sie bestätigen immer mit Enter und geben dann den zweiten Wert ein. (Ohmsches Gesetz: R = U / I)");

            double u = 0,
                   r = 0,
                   i = 0;

            int correctInputs = 0;

            bool uEntered = false;
            bool rEntered = false;
            bool iEntered = false;

            while (correctInputs < 2)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    string[] parts = input.Split("=");
                    if (parts.Length != 2)
                    {
                        Console.WriteLine("Es fehlt ein gleichzeichen in der Eingabe. Eingabe sollte so aussehen: R = 1.5");
                        continue;
                    }
                    parts[0] = parts[0].Trim().ToLower();
                    parts[1] = parts[1].Trim();

                    switch (parts[0])
                    {
                        case "u" when !uEntered:
                            if (double.TryParse(parts[1], out u))
                            {
                                uEntered = true;
                                break;
                            }
                            else
                                Console.WriteLine("Ungültige Eingabe. Nach dem Gleichzeichen muss ein Zahlenwert stehen!");
                            continue;
                        case "r" when !rEntered:
                            if (double.TryParse(parts[1], out r))
                            {
                                rEntered = true;
                                break;
                            }
                            else
                                Console.WriteLine("Ungültige Eingabe. Nach dem Gleichzeichen muss ein Zahlenwert stehen!");
                            continue;
                        case "i" when !iEntered:
                            if (double.TryParse(parts[1], out i))
                            {
                                iEntered = true;
                                break;
                            }
                            else
                                Console.WriteLine("Ungültige Eingabe. Nach dem Gleichzeichen muss ein Zahlenwert stehen!");
                            continue;
                        default:
                            Console.WriteLine("Ungültiger Buchstabe oder Wert wurde schon gesetzt. Gültige Buchstaben sind U, R und I.");
                            continue;
                    }

                    correctInputs++;
                    break;
                }
            }

            if (!uEntered)
                u = r * i;
            else if (!rEntered)
                r = u / i;
            else
                i = u / r;

            Console.WriteLine();
            Console.WriteLine("U = " + u + "V");
            Console.WriteLine("R = " + r + "Ohm");
            Console.WriteLine("I = " + i + "A");
        }
    }
}
