using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem7 : Problem
    {
        protected override long DoSolutionSolve()
        {
            var prime = ProblemUtilities.Primes().Skip(10000).First();
            Progress = 100;
            return prime;
        }
    }
}
