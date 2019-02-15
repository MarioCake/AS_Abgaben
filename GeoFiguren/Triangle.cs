using System;

namespace GeoFiguren
{
    public class Triangle : Figure
    {
        public double Gamma { get; private set; }

        public double Beta { get; private set; }

        public double Alpha { get; private set; }

        public double HeightC { get; private set; }

        public double HeightB { get; private set; }

        public double HeightA { get; private set; }
        public double SideA { get; private set; }
        public double SideC { get; private set; }

        public double SideB { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SetNewSides(sideA, sideB, sideC);
        }

        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideC > sideB &&
                   sideB + sideC > sideA &&
                   sideA + sideB > sideC;
        }

        private void SetNewSides(double sideA, double sideB, double sideC)
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Sum of two sides need to be bigger than third side.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            RecalculateEverything();
        }


        private void RecalculateEverything()
        {
            CalculateArea();
            CalculateCircumference();
        }

        private void CalculateCircumference()
        {
            Circumference = SideA + SideB + SideC;
        }

        private void CalculateArea()
        {
            CalculateHeights();
            Area = HeightA * SideA / 2;
        }

        private void CalculateAngles()
        {
            Alpha = CalculateAngle(SideB, SideC, SideA);
            Beta = CalculateAngle(SideA, SideC, SideB);
            Gamma = CalculateAngle(SideA, SideB, SideC);
        }

        private void CalculateHeights()
        {
            CalculateAngles();
            HeightA = CalculateHeight(Gamma, SideB);
            HeightB = CalculateHeight(Alpha, SideC);
            HeightC = CalculateHeight(Beta, SideA);
        }

        private static double CalculateHeight(double oppositeAngle, double adjacentSide)
        {
            return adjacentSide * Math.Sin(oppositeAngle);
        }

        private static double CalculateAngle(double sideA, double sideB, double sideC)
        {
            return Math.Acos((sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB));
        }
    }
}