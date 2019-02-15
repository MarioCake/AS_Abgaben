using System;

namespace GeoFiguren
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            SetNewRadius(radius);
        }

        public void SetNewRadius(double radius)
        {
            Radius = radius;
            RecalculateEverything();
        }

        private void RecalculateEverything()
        {
            CalculateArea();
            CalculateCircumference();
        }

        private void CalculateArea()
        {
            Area = Radius * Radius * Math.PI;
        }

        private void CalculateCircumference()
        {
            Circumference = 2 * Radius * Math.PI;
        }
    }
}