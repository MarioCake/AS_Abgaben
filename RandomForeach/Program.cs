using System;

namespace RandomForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator1 generator1 = new RandomNumberGenerator1(10, 10);
            RandomNumberGenerator2 generator2 = new RandomNumberGenerator2(10, 10);

            foreach (int number in generator1) Console.WriteLine(number);

            Console.WriteLine("----------------------------------");

            foreach (int number in generator2) Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
