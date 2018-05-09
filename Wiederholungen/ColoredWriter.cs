using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen
{
    public static class ColoredWriter
    {
        public static void Write(object text, ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            using(new ColorChanger(foregroundColor, backgroundColor))
            {
                Console.Write(text);
            }
        }

        public static void WriteLine(object text, ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            using (new ColorChanger(foregroundColor, backgroundColor))
            {
                Console.WriteLine(text);
            }
        }
    }
}
