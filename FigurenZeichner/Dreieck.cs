namespace Figurenzeichner
{
    class Dreieck : Figur
    {
        //Methoden
        public Dreieck(Vector2d[] arrayKoordinaten) : base(arrayKoordinaten)
        {
            BerechneMittelpunkt();
            //TransformiereMittelpunktInUrsprung();
        }

        //Berechnet den Mittelpunkt des Dreiecks
        private void BerechneMittelpunkt()
        {   
            Mittelpunkt = arrayKoordinaten.Average();
        }
    }
}