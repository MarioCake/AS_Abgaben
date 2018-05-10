using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomForeach
{
    class RandomNumberGenerator2 : IEnumerable<int>
    {
        private int _min;
        private int _max;

        private uint _amount;
        private Random random = new Random();
        public RandomNumberGenerator2(uint amount, int max) : this(amount, 0, max) { }

        public RandomNumberGenerator2(uint amount, int min, int max)
        {
            _amount = amount;
            _min = min;
            _max = max;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < _amount; i++) yield return random.Next(_min, _max);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
