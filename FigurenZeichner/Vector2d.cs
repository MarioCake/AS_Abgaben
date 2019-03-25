using System;
using System.Drawing;

namespace Figurenzeichner
{
    public class Vector2d
    {
        public double X;
        public double Y;

        public Vector2d(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public void Add(Vector2d other)
        {
            X += other.X;
            Y += other.Y;
        }
        
        public void Subtract(Vector2d other)
        {
            X -= other.X;
            Y -= other.Y;
        }
        
        public void Multiply(double factor)
        {
            X *= factor;
            Y *= factor;
        }

        public void Rotate(Vector2d rotationVector2d, double angle)
        {
            Subtract(rotationVector2d);
            
            Rotate(angle);
            
            Add(rotationVector2d);
        }

        public void Rotate(double angle)
        {
            var oldX = X;
            var oldY = Y;
            X = oldX * Math.Cos(angle) - oldY * Math.Sin(angle);
            Y = oldX * Math.Sin(angle) + oldY * Math.Cos(angle);
        }
        
        public static implicit operator Point(Vector2d vector2d)
        {
            return new Point((int)Math.Round(vector2d.X), (int)Math.Round(vector2d.Y));
        }

        public static implicit operator Vector2d(Point point)
        {
            return new Vector2d(point.X, point.Y);
        }
    }
}