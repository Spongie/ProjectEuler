using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem3 : Problem
    {
        private bool IsPrime(int number)
        {
            if (number % 2 == 0)
                return false;

            for (int i = 3; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private IEnumerable<int> Primes()
        {
            int number = 2;

            while (true)
            {
                if (IsPrime(number))
                {
                    yield return number;
                }

                number++;
            }
        }

        protected override long DoSolutionSolve()
        {
            long primeFactor = 0;
            long target = 600851475143;
            long max = (long)Math.Sqrt(target);

            foreach (var prime in Primes())
            {
                if (prime > max)
                    break;

                if (target % prime == 0)
                    primeFactor = prime;
            }

            Progress = 100;

            return primeFactor;
        }
    }
}
