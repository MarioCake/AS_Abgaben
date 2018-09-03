using System;
using System.Collections.Generic;
using System.Text;

namespace EVA
{
    public class SphereCalculation : SchoolTask
    {
        protected SphereCalculation() : base() { }
        static SphereCalculation() { new SphereCalculation(); }
        public new static void Init() { }

        public override void RunTask()
        {
            Console.Write("Geben Sie den Raduis an, der zur Kugelberechnung verwendet werden soll: ");

            double radius;
            while(!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
            {
                Console.WriteLine("Sie haben keine valide Zahl eingegeben. Die Zahl muss größer als 0 sein.");
            }
            double circumference = 2 * Math.PI * radius;
            double area = 4.0 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine("Radius:            " + radius);
            Console.WriteLine("Umfang:            " + circumference);
            Console.WriteLine("Oberflächeninhalt: " + area);
            Console.WriteLine("Volumen:           " + volume);

        }
    }
}
