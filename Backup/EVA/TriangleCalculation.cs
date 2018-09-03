using System;
using System.Collections.Generic;
using System.Text;

namespace EVA
{
    public class TriangleCalculation : SchoolTask
    {
        protected TriangleCalculation() : base() { }
        static TriangleCalculation() { new TriangleCalculation(); }
        public new static void Init() { }

        public override void RunTask()
        {
            Console.Write("Länge der ersten Kathete a: ");
            double katheteA;
            while (!double.TryParse(Console.ReadLine(), out katheteA) || katheteA < 0)
                Console.WriteLine("Die Kathete muss eine Zahl größer als 0 sein.");
            Console.Write("Länge der ersten Kathete b: ");

            double katheteB;
            while (!double.TryParse(Console.ReadLine(), out katheteB) || katheteB < 0)
                Console.WriteLine("Die Kathete muss eine Zahl größer als 0 sein.");

            double hypotenuse = Math.Sqrt(Math.Pow(katheteA, 2) + Math.Pow(katheteB, 2));
            double alpha = Math.Asin(katheteA / hypotenuse) * 180d / Math.PI;
            double beta = 90d - alpha;

            Console.WriteLine("Kathete A:  " + katheteA);
            Console.WriteLine("Kathete B:  " + katheteB);
            Console.WriteLine("Hypotenuse: " + hypotenuse);
            Console.WriteLine("Alpha:      " + alpha);
            Console.WriteLine("Beta:       " + beta);

        }
    }   
}
