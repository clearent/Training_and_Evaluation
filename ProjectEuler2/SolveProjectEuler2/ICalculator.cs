using System.Collections.Generic;

namespace SolveProjectEuler2
{
    public interface ICalculator
    {
        long AddList(IList<long> listOfNumbers);
        long AddList(IList<long> listOfNumbers, IEvenNumberFilter filter);
    }
}
