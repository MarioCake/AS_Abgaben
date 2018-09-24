using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveMethods
{
    public class SortAlgorithms : School.SchoolTask
    {
        public SortAlgorithms(): base("Sortier Algorithmus") { }

        protected override void Main(string[] args)
        {
            RecursiveBubble(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
        }

        public int[] RecursiveBubble(int[] args)
        {
            Console.WriteLine("Startindex\t| Endindex\t| Values");

            int[] result = RecursiveBubble(args, 0, args.Length);

            return result;
        }

        private int[] RecursiveBubble(int[] args, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                Console.WriteLine("Recursiv bubblesort:");
                foreach (int arg in args)
                    Console.Write(arg + " ");
                return args;
            }
            string value = String.Format("{0}\t\t| {1}\t\t| {2}|", startIndex, endIndex, String.Join("| ", args.Select(arg => arg.ToString().PadRight(3))));
            Console.Write(value);
            Console.WriteLine(Environment.NewLine.PadRight(Console.CursorLeft+2, '-'));

            if (startIndex == endIndex - 1)
            {
                RecursiveBubble(args, 0, endIndex - 1);
            }
            else if (args[startIndex] > args[startIndex + 1])
            {
                int currentNumber = args[startIndex];
                args[startIndex] = args[startIndex + 1];
                args[startIndex + 1] = currentNumber;
                RecursiveBubble(args, startIndex + 1, endIndex);
            }
            else
            {
                RecursiveBubble(args, startIndex + 1, endIndex);
            }
            return args;
        }
    }
}
