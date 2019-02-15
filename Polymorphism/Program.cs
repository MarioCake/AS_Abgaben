using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            var haustierliste = new List<Haustier>
            {
                new Haustier(),
                new Hund(),
                new Katze()
            };


            foreach (var einHaustier in haustierliste)
                Console.WriteLine("Ein(e) " + einHaustier.Art + " macht " +
                                  einHaustier.Geraeusch);

            Console.Read();
        }
    }
}