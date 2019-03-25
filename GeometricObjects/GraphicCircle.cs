using System;

namespace GeometricObjects
{
    public class GraphicCircle : Circle, IDraw
    {
        // Konstruktoren
        public GraphicCircle() { }
        public GraphicCircle(double radius) : base(radius) { }
        public GraphicCircle(double radius, int xPos, int yPos) : base(radius, xPos, yPos) { }

        // Typspezifische Methode
        public virtual void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet");
        }
    }
}
