namespace SolveProjectEuler2
{
    public class EvenNumberFilter : IEvenNumberFilter
    {
        public bool IsEven(long number)
        {
            return (number % 2 == 0);
        }
    }
}
