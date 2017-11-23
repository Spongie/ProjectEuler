using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem16 : Problem
    {
        protected override long DoSolutionSolve()
        {
            return new BigInteger(Math.Pow(2, 1000)).ToString().ToCharArray().Select(x => Convert.ToInt64(x.ToString())).Sum();
        }
    }
}
