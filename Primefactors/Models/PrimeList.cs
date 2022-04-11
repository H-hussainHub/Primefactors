using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primefactors.Models
{
    public class PrimeList
    {
        private static List<int> _primes;
        private int _lastChecked;

        public PrimeList()
        {
            _primes = new List<int>();
            _lastChecked = 2;
        }
    }
}
