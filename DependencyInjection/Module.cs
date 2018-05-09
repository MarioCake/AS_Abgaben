using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Module
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine(this.GetType().FullName + ": " + Name);
        }
    }
}
