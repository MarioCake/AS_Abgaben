using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInstances
{
    public class RaumschiffUssEnterprise

    {

        private static Random _rand = new Random();

        private int _photonentorpedoAnz = 20;

        private int _energieversorgung = 100;

        private int _zustandSchilde = 100;

        private int _zustandHuelle = 100;

        private int _zustandLebenserhaltungssysteme = 100;

        private const bool Droide = true;

        public double MaximalGeschwindigkeitErmitteln()

        {

            if (_energieversorgung == 100)

                return 1079252848.8;

            if (_energieversorgung > 50)

                return 252.792;

            if (_energieversorgung > 5)

                return 5.08;

            return 0;

        }

        public void PhotonentorpedoSchiessen()

        {

            if (_photonentorpedoAnz == 0)

                Console.WriteLine("-=*Click*=-");

            else
            {

                _photonentorpedoAnz--;

                Console.WriteLine("Photonentorpedo abgeschossen");
            }

        }

        public void PhaserkanoneSchiessen()

        {

            if (_energieversorgung < 15)

                Console.WriteLine("-=*Click*=-");

            else
            {

                _energieversorgung = _energieversorgung - 15;

                Console.WriteLine("Phaserkanone abgeschossen");
            }

        }

        public void DroideEinsetzen()

        {

            if (Droide)

            {

                if (_zustandLebenserhaltungssysteme < 100)

                    Wartung(ref _zustandLebenserhaltungssysteme);

                else if (_energieversorgung < 100)

                    Wartung(ref _energieversorgung);

                else if (_zustandSchilde < 100)

                    Wartung(ref _zustandSchilde);

                else if (_zustandHuelle < 100)

                    Wartung(ref _zustandHuelle);

            }

        }

        public static string KapitaenErmitteln()
        {

            string[] kapitaene = { "Jonathan Archer", "Robert April", "Christopher Pike",

                                   "James Tiberius Kirk", "Spock", "Willard Decker",

                                   "John Harriman", "Rachel Garrett", "Jean-Luc Picard",

                                   "William T. Riker", "Edward Jellico" };

            return kapitaene[_rand.Next(10)];

        }

        private static void Wartung(ref int system)

        {

            system = system + 50;

            if (system > 100) system = 100;

        }

    }

}
