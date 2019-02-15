using System;

namespace Waschmittel
{
    class Program
    {
        static void Main(string[] args)
        {
            Waschmittel w = new Waschmittel();
            Waschmittel ww = new WollWaschmittel();
            WollWaschmittel www = new WollWaschmittel();

            w.Reinigen();
            ww.Reinigen();
            www.Reinigen();

            ((WollWaschmittel)ww).Reinigen();


        }
    }
}
