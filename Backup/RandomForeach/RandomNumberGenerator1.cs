using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomForeach
{
    class RandomNumberGenerator1 : IEnumerable<int>, IEnumerator<int>
    {
        private int _min;
        private int _max;

        private uint _amount;
        private int _currentGeneratedNumber;


        private Random _random = new Random();

        private int _currentRandomNumber;

        public int Current => _currentRandomNumber;
        
        object IEnumerator.Current => _currentRandomNumber;

        public RandomNumberGenerator1(uint amount, int max) : this(amount, 0, max) { }

        public RandomNumberGenerator1(uint amount, int min, int max)
        {
            _amount = amount;
            _min = min;
            _max = max;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            _currentRandomNumber = _random.Next(_min, _max);

            return _currentGeneratedNumber++ < _amount;
        }

        public void Reset()
        {
            _currentGeneratedNumber = 0;
        }

        public IEnumerator<int> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;
    }
}
