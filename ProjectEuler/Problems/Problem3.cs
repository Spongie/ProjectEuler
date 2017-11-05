using System;

namespace ProjectEuler.Problems
{
    public class Problem3 : Problem
    {
        protected override long DoSolutionSolve()
        {
            long primeFactor = 0;
            long target = 600851475143;
            long max = (long)Math.Sqrt(target);

            foreach (var prime in ProblemUtilities.Primes())
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
