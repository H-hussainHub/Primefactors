using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Primefactors.ViewModels
{
    class EratosthenesViewModel : IEnumerable<int>
    {
        // Storing the prime numbers within a collection
        private static List<int> _primes = new List<int>();
        private int _lastChecked;


        public EratosthenesViewModel()
        {
            _primes.Add(2);
            _lastChecked = 2;
        }


        // Method to check if a number is prime which returns a boolean value that is true/false
        private bool IsPrime(int checkValue)
        {
            bool isPrime = true;

            foreach (int prime in _primes)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }


        public IEnumerator<int> GetEnumerator()
        {
            foreach (int prime in _primes)
                yield return prime;

            while (_lastChecked < int.MaxValue)
            {
                _lastChecked++;

                if (IsPrime(_lastChecked))
                {
                    _primes.Add(_lastChecked);
                    yield return _lastChecked;
                }
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
