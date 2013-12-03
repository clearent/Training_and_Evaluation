using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProjectEuler2
{
    public class FibonacciSequencer : IFibonacciSequencer
    {
        public IList<long> GenerateFibonacciSequence(long first, long second, long max, IList<long> l)
        {
            var x = first + second;
            if (x <= max)
            {
                l.Add(x);
                l = GenerateFibonacciSequence(second, x, max, l);
            }

            return l;
        }
    }
}
