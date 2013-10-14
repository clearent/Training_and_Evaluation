using System;
using System.Collections.Generic;

namespace SolveProjectEuler2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pgm = new Program();
            var calc = new Calculator();
            var filter = new EvenNumberFilter();

            List<long> l = new List<long>();
            var z = pgm.GenerateFibonacciSequence(0, 1, 4000000, l);
            var result = calc.AddList(z, filter);

            Console.WriteLine("This program calculates the sum of all even numbers in the Fibonacci Sequence up to 4,000,000.");
            Console.WriteLine("The problem is better defined at http://projecteuler.net/problem=2.");
            Console.WriteLine("The answer is: {0}", result);
            Console.WriteLine("Hit any key to end the program.");
            Console.ReadLine();
        }

        private List<long> GenerateFibonacciSequence(long first, long second, long max, List<long> l)
        {
            var x = first + second;
            if (x <= max)
            {
                l.Add(x);
                l = GenerateFibonacciSequence(second, x, max-x, l);
            }

            return l;
        }
    }
}
