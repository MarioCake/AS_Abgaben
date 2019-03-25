using System;

namespace GeometricObjects
{
    public abstract class GeometricObject
    {
        // Statisches Feld
        private static int _CountGeometricObjects;

        public static int CountGeometricObjects
        {
            get { return _CountGeometricObjects; }
        }

        // Konstruktor
        protected GeometricObject()
        {
            _CountGeometricObjects++;
        }


        public Vector Point;

        // Abstrakte Methoden
        public abstract double GetArea();
        public abstract double GetCircumference();

        // Instanzmethoden
        public virtual int Bigger(GeometricObject rect)
        {
            return Math.Sign(GetArea() - rect.GetArea());
        }

        public virtual void Move(int dx, int dy)
        {
            Point.Add(dx, dy);
        }

        // Klassenmethode
        public static int Bigger(GeometricObject geoObj1, GeometricObject geoObj2)
        {
            return geoObj1.Bigger(geoObj2);
        }
    }
}