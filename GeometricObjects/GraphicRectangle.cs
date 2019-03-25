using System;

namespace GeometricObjects
{
    public class GraphicRectangle : Rectangle, IDraw
    {
        // --------- Konstruktoren ---------------
        public GraphicRectangle() { }

        public GraphicRectangle(double length, double width) : base(length, width) { }

        public GraphicRectangle(double length, double width, int xPos, int yPos) : base(length, width, xPos, yPos) { }

        // Typspezifische Methode
        public virtual void Draw()
        {
            Console.WriteLine("Das Rechteck wird gezeichnet");
        }
    }
}
