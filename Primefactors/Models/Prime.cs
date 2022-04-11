using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primefactors.Models
{
    public class Prime
    {
        public List<int> _primes { get; set; }

        public int lastChecked { get; set; }

        public int Number
        {
            get;
            set;
        }

    }
}
