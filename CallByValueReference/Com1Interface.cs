using System;
using System.Collections.Generic;
using System.Text;

namespace CallByValueReference
{
    public class Com1Interface : IDisposable
    {
        private bool open;

        public bool IsOpen()
        {
            return open;
        }

        public void Open()
        {
            if (open)
                throw new InvalidOperationException("Cannot open already opened COM1 interface");

            open = true;

        }

        public void Close()
        {
            open = false;
        }

        public double Read()
        {
            if (!open)
                throw new InvalidOperationException("Cannot read COM1 interface if it is closed");

            return (new Random((int)DateTime.Now.Ticks)).NextDouble();
        }

        public void Dispose()
        {
            if (IsOpen())
                Close();
        }
    }
}
