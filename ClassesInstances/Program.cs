using System;

namespace ClassesInstances
{
    class Program
    {
        static void Main(string[] args)
        {

            //Raumschiff bauen:

            RaumschiffUssEnterprise raumschiff = new RaumschiffUssEnterprise();


            //Kapitän ermitteln und ausgeben:

            Console.WriteLine("Kapitän: {0}", RaumschiffUssEnterprise.KapitaenErmitteln());


            //Phaserkanonen schiessen:

            raumschiff.PhaserkanoneSchiessen();


            //Maximale Geschwindigkeit ausgeben:

            Console.WriteLine("Maximalgeschwindigkeit: {0}", raumschiff.MaximalGeschwindigkeitErmitteln());


            //Droide einsetzen:

            raumschiff.DroideEinsetzen();


            //Maximale Geschwindigkeit ausgeben:

            Console.WriteLine("Maximalgeschwindigkeit: {0}", raumschiff.MaximalGeschwindigkeitErmitteln());


            //Phaserkanone schiessen:

            raumschiff.PhaserkanoneSchiessen();

            Console.ReadKey();

        }

        /**
         * Frage:
         *  Stellen Sie sich vor Sie müssten noch 3 weitere 
         *  Raumschiffe (Tie Fighter, x-Wing und die Herz aus Gold) erstellen, 
         *  ist dieser Quellcode dafür geeignet? 
         *  Begründen Sie Ihre Antwort.
         * 
         * Antwort:
         *  Der Code ist dafür nicht geeignet. Die Klasse beschreibt eine Art
         *  von Raumschiff und nicht ein Raumschiff im allgemeinen. Auch müssten 
         *  die Attribute anpassbar sein selbst wenn es eine allgemeine Klasse wäre
         *  für Raumschiffe.
         */

        /**
         * Frage:
         *  Recherchieren oder nennen Sie Vor- und Nachteile von statischen 
         *  Methoden. Sollte ein Quellcode möglichst viele oder möglichst 
         *  wenige statische Methoden beinhalten? Nennen Sie eine Ihnen bekannte 
         *  statische Methode.
         * 
         * Antwort:
         *  Statische Methoden haben den Vorteil, dass bei gleicher Eingabe
         *  immer gleiche sachen passieren und es keinen Zustand gibt.
         *  Nachteil ist natürlich, dass es keinen Zustand gibt und nicht
         *  auf vorherige Ausführungen gut bezug genommen werden kann, falls keine
         *  statische Attribute verwendet werden.
         *  Statische Methoden sollten grundsätzlich wenige verwendet werden, da es
         *  nicht nach den Prinzipien der Objektorientierung entspricht.
         *  Instanzmethoden haben den Vorteil, dass sie sich auf den Zustand eines 
         *  Objekts beziehen kann und direkt dieses Objekt verändern kann.
         *  Dabei hat jeder Aufruf nicht unbedingt immer die gleiche Ausgabe oder
         *  funktionalität.
         * 
         */
    }
}
