using System;
using System.Collections.Generic;
using System.Text;
using static School.Helper;
using System.Linq;

namespace Arrays
{
    class Temperatur : School.SchoolTask
    {
        #region
        public Temperatur() : base("Temperatur") { }
        #endregion

        protected override void Main(string[] args)
        {
            string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };

            Console.WriteLine("Geben Sie die Temperaturen der letzen Woche Montag bis Sonntag ein.");

            double[] temperature = GetArrayOf<double>(wochentage.Length, (currentIndex, last) =>
            {
                Console.Write("{0}: ", wochentage[currentIndex]);
                return true;
            }, errorMessage: "Geben Sie eine gültige Zahl für die Temperatur ein.");
             
            double durchschnittsTemperatur = temperature.Average();
            Dictionary<string, double> wochentageTemperatur = new Dictionary<string, double>();
            for (int i = 0; i < wochentage.Length; i++)
                wochentageTemperatur[wochentage[i]] = temperature[i];

            int temperaturÜberNull = (int)temperature.Aggregate(0, (agg, value) => value < 0 ? agg : (agg + 1));

            KeyValuePair<string, double> höchsteTemperatur = wochentageTemperatur.First(value => value.Value == temperature.Max());
            KeyValuePair<string, double> niedrigsteTemperatur = wochentageTemperatur.First(value => value.Value == temperature.Min());

            Console.WriteLine("Durchschnittstemperatur: {0}", durchschnittsTemperatur);
            Console.WriteLine("Tage über 0°C: {0}", temperaturÜberNull);
            Console.WriteLine("Wärmster Tag {0} hatte eine Temperatur von {1}°C.", höchsteTemperatur.Key, höchsteTemperatur.Value);
            Console.WriteLine("Kältester Tag {0} hatte eine Temperatur von {1}°C.", niedrigsteTemperatur.Key, niedrigsteTemperatur.Value);

        }
    }
}
