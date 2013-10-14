using System.Collections.Generic;

namespace SolveProjectEuler2
{
    public class Calculator : ICalculator
    {
        public long AddList(IList<long> listOfNumbers)
        {
            long r = 0;

            if (listOfNumbers != null)
            {
                foreach (var i in listOfNumbers)
                {
                    r += i;
                }
            }

            return r;
        }

        public long AddList(IList<long> listOfNumbers, IEvenNumberFilter filter)
        {
            long r = 0;

            if (listOfNumbers != null)
            {
                foreach (var i in listOfNumbers)
                {
                    r += filter.IsEven(i) ? i : 0;
                }
            }

            return r;
        }
    }
}
