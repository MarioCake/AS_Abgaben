namespace GeoFiguren
{
    public class Rectangle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }


        public Rectangle(double sideA, double sideB)
        {
            SetNewSides(sideA, sideB);
            
        }

        public void SetNewSides(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            RecalculateEverything();
        }

        private void RecalculateEverything()
        {
            CalculateArea();
            CalculateCircumference();
        }

        private void CalculateArea()
        {
            Area = SideA * SideB;
        }

        private void CalculateCircumference()
        {
            Circumference = 2 * (SideA + SideB);
        }
    }
}