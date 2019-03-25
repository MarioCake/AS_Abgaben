using System.Collections.Generic;
using System.Drawing;

namespace Figurenzeichner
{
    public static class PointHelper
    {
        public static Vector2d Average(this IEnumerable<Vector2d> points)
        {
            double sumX = 0;
            double sumY = 0;
            var count = 0;
            foreach (var point in points)
            {
                sumX += point.X;
                sumY += point.Y;
                count++;
            }

            return count > 0 ? new Vector2d(sumX / count, sumY / count) : new Vector2d();
        }

        public static Point[] ToPointArray(this Vector2d[] vectors)
        {
            var points = new Point[vectors.Length];

            for (var i = 0; i < points.Length; i++)
            {
                points[i] = vectors[i];
            }

            return points;
        }

        
    }
}