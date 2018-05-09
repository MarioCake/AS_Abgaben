using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen
{
    public struct Vector2<T>
    {
        public T X;
        public T Y;

        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
