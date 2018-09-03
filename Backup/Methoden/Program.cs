using School;
using System;
using static School.Helper;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolTask.LoadAssembly(typeof(Program).Assembly, args);

        }
    }
}
