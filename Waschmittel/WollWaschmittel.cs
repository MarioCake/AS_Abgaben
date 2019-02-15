using System;
using System.Collections.Generic;
using System.Text;

namespace Waschmittel
{
    class WollWaschmittel : Waschmittel
    {
        public new void Reinigen()
        {
            Console.WriteLine("WollWaschmittel");
        }
    }
}
