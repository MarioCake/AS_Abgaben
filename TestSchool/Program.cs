using System;
using School;
using System.Reflection;

namespace TestSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolTask.LoadAssembly(typeof(Program).Assembly, args);
        }
    }
}
