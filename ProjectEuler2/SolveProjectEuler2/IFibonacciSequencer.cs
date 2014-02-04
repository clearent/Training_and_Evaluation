using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProjectEuler2
{
    public interface IFibonacciSequencer
    {
        IList<long> GenerateFibonacciSequence(long first, long second, long max, IList<long> l);
    }
}
