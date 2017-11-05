using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem6 : Problem
    {
        protected override long DoSolutionSolve()
        {
            var sumOfSquares = Enumerable.Range(1, 100).Select(number => number * number).Sum();
            var squareOfSum = Math.Pow(Enumerable.Range(1, 100).Sum(), 2);

            Progress = 100;
            return (int)squareOfSum - sumOfSquares;
        }
    }
}
