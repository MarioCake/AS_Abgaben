using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen
{
    public class ColorChanger : IDisposable
    {
        private ConsoleColor oldForegroundColor;
        private ConsoleColor oldBackgroundColor;

        public ColorChanger(ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            oldBackgroundColor = Console.BackgroundColor;
            oldForegroundColor = Console.ForegroundColor;
            if (!backgroundColor.HasValue) backgroundColor = oldBackgroundColor;
            if (!foregroundColor.HasValue) foregroundColor = oldForegroundColor;

            Console.BackgroundColor = backgroundColor.Value;
            Console.ForegroundColor = foregroundColor.Value;
        }

        public void Dispose()
        {
            Console.BackgroundColor = oldBackgroundColor;
            Console.ForegroundColor = oldForegroundColor;
        }
    }
}
