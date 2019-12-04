using System;
using System.Collections.Generic;
using System.Text;

namespace GetStart
{
    public class HelloEnumerator
    {
        public HelloEnumerator(long maxIter)
        {
            _maxIter = maxIter;
            _counter = 0;
        }
        public IEnumerable<string> GetEnumerator()
        {
            while (true)
            {
                _counter++;
                if (_counter % 2 == 1)
                {
                    yield return "Hello";
                }
                else
                {
                    yield return "Enumerator";
                }

                if (_counter >= _maxIter)
                {
                    yield break;
                }
            }
        }

        public long GetCounter()
        {
            return _counter;
        }

        private readonly long _maxIter;
        private long _counter;
    }
}
