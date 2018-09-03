using System;
using System.Collections.Generic;
using System.Text;
using static School.Helper;

namespace QueuesStacksLists
{
    class StackTask : School.SchoolTask
    {
        public StackTask() : base("Stack Aufgabe") { }

        private static void PrintStack(Stack<char> stack)
        {
            foreach (char value in stack)
                Console.WriteLine("  " + value);

            Console.WriteLine();
        }

        private static void PrintStacks(List<Stack<char>> allStacks)
        {
            for (int i = 0; i < allStacks.Count; i++)
            {
                Console.WriteLine("STACK {0}:", i + 1);
                PrintStack(allStacks[i]);
            }
        }

        protected override void Main(string[] args)
        {
            Stack<char> stack1 = new Stack<char>(new[] { 'A', 'B', 'C' });
            Stack<char> stack2 = new Stack<char>(new[] { 'A', 'B', 'C' });
            Stack<char> stack3 = new Stack<char>(new[] { 'A', 'B', 'C' });

            List<Stack<char>> allStacks = new List<Stack<char>> { stack1, stack2, stack3 };

            bool run = true;
            while (run)
            {
                PrintStacks(allStacks);
                Console.WriteLine("Was möchten Sie tun? (0 beendet das Programm)");

                Console.Write("Stack ");
                TryRepeatedConsoleParse(
                    out int firstStack,
                    $"Keine valide Eingabe. Es muss eine Zahl zwischen 1 und {allStacks.Count} inklusive sein! Der Stack darf auch nicht leer sein!",
                    value => value == 0 || (value > 0 && value <= allStacks.Count && allStacks[value - 1].Count != 0)
                 );

                if (firstStack != 0)
                {
                    Console.Write("auf" + Environment.NewLine + "Stack ");
                    TryRepeatedConsoleParse(
                        out int secondStack,
                        $"Keine valide Eingabe. Es muss eine Zahl zwischen 1 und {allStacks.Count} inklusive sein!",
                        value => value >= 0 && value <= allStacks.Count
                    );

                    if (secondStack != 0)
                    {
                        firstStack--;
                        secondStack--;

                        allStacks[secondStack].Push(allStacks[firstStack].Pop());
                        Console.WriteLine();
                    }
                    else run = false;
                }
                else run = false;
            }
        }
    }
}
