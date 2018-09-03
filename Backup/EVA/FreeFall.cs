using System;
using System.Collections.Generic;
using System.Text;

namespace EVA
{
    public class FreeFall : SchoolTask
    {
        protected FreeFall() : base() { }
        static FreeFall() { new FreeFall(); }
        public new static void Init() { }

        public override void RunTask()
        {
            const double acceleration = 9.81d;

            Console.Write("Geben Sie eine gewünschte Fallhöhe in Meter an: ");
            double fallHeight;

            while (!double.TryParse(Console.ReadLine(), out fallHeight) || fallHeight < 0)
                Console.WriteLine("Die fallhöhe muss eine Zahl größer als 0 sein.");

            double velocity = Math.Sqrt(2 * fallHeight * acceleration);
            double time = velocity / acceleration;

            Console.WriteLine("Fallhöhe:           " + fallHeight + " m");
            Console.WriteLine("Endgeschwindigkeit: " + velocity + " m/s");
            Console.WriteLine("Fallzeit:           " + time + " s");

        }
    }
}
