using System;
using System.Collections.Generic;
using System.Text;
using School;

namespace TestSchool
{
    public class TestTask : SchoolTask
    {
        public TestTask():base("Test Task")
        {}

        protected override void Main(string[] args)
        {
            Console.WriteLine("TestTask");
        }
    }
}
