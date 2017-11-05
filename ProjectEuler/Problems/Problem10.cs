using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem10 : Problem
    {
        protected override long DoSolutionSolve()
        {
            var sum = 0L;
            foreach(var prime in ProblemUtilities.Primes())
            {
                if (prime >= 2000000)
                    break;

                sum += prime;
            }

            Progress = 100;

            return sum;
        }
    }
}
