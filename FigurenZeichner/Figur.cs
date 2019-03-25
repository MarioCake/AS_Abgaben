using System;
using System.Drawing;

namespace Figurenzeichner
{
    public abstract class Figur
    {
        //Attribute
        protected Vector2d[] arrayKoordinaten;

        //Properties
        public Vector2d Mittelpunkt { get; protected set; }

        public Vector2d[] ArrayKoordinaten
        {
            get
            {
                //Gibt eine Kopie (keine Referenz!) des Koordinaten-Arrays zurueck
                var arrayTmp = new Vector2d[arrayKoordinaten.Length];
                arrayKoordinaten.CopyTo(arrayTmp, 0);
                return arrayTmp;
            }
        }

        //Methoden
        protected Figur(Vector2d[] listKoordinaten) //Konstruktor
        {
            arrayKoordinaten = new Vector2d[listKoordinaten.Length];
            listKoordinaten.CopyTo(arrayKoordinaten, 0); //Achtung: Kopie erstellen!
        }

        //Dreht die Koordinaten einer Figur um einen bestimmten Winkel
        /// <summary>
        /// Drehe die Figur um ihren Mittelpunkt
        /// </summary>
        /// <param name="winkel">Winkel in Grad</param>
        public void DreheFigur(double winkel)
        {
            foreach (var vector in arrayKoordinaten)
            {
                vector.Rotate(Mittelpunkt, winkel * (Math.PI / 180d));
            }
        }

        //Transformiert alle Koordinaten einer Figur, sodass der Mittelpunkt im Ursprung liegt
        protected void TransformiereMittelpunktInUrsprung()
        {
            var movement = new Vector2d();
            movement.Subtract(Mittelpunkt);
            Mittelpunkt = new Vector2d();

            Move(movement);
        }

        private void Move(Point movement)
        {
            foreach (var vector2d in arrayKoordinaten)
            {
                vector2d.Add(movement);
            }
        }
    }
}