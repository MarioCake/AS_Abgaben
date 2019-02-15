using System;

namespace GeoFiguren
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(15d);
            var r = new Rectangle(5d, 6.5d);
            var t = new Triangle(3,4,5);

            Console.WriteLine("KREIS:");
            Console.WriteLine("\tRadius  = {0}", c.Radius);
            Console.WriteLine("\tUmfang  = {0}", c.Circumference);
            Console.WriteLine("\tFlaeche = {0}", c.Area);

            Console.WriteLine("\nRECHTECK:");
            Console.WriteLine("\tSeiteA  = {0}", r.SideA);
            Console.WriteLine("\tSeiteB  = {0}", r.SideB);
            Console.WriteLine("\tUmfang  = {0}", r.Circumference);
            Console.WriteLine("\tFlaeche = {0}", r.Area);

            Console.WriteLine("\nDREIECK:");
            Console.WriteLine("\tSeiteA  = {0}", t.SideA);
            Console.WriteLine("\tSeiteB  = {0}", t.SideB);
            Console.WriteLine("\tSeiteC  = {0}", t.SideC);
            Console.WriteLine("\tHoeheA  = {0}", t.HeightA);
            Console.WriteLine("\tHoeheB  = {0}", t.HeightB);
            Console.WriteLine("\tHoeheC  = {0}", t.HeightC);
            Console.WriteLine("\tAlpha  = {0}", t.Alpha * 180 / Math.PI);
            Console.WriteLine("\tBeta  = {0}", t.Beta * 180 / Math.PI);
            Console.WriteLine("\tGamma  = {0}", t.Gamma * 180 / Math.PI);
            Console.WriteLine("\tUmfang  = {0}", t.Circumference);
            Console.WriteLine("\tFlaeche = {0}", t.Area);
            Console.ReadKey();
        }
    }
}