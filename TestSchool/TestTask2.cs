using System;
using System.Collections.Generic;
using System.Text;
using School;

namespace TestSchool
{
    public class TestTask2 : SchoolTask
    {
        public TestTask2():base("Test Task2")
        {}

        protected override void Main(string[] args)
        {
            Console.WriteLine("TestTask 2");
        }
    }
}
