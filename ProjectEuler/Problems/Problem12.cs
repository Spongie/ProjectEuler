using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem12 : Problem
    {
        //Superslow but works...
        protected override long DoSolutionSolve()
        {
            int current = 1;
            int lastCount = 0;

            while (true)
            {
                var triangle = GetTriangleSum(current);
                var divisorCount = GetDivisorCount(triangle);

                if (divisorCount > 500)
                {
                    Progress = 100;
                    return triangle;
                }

                if (divisorCount > lastCount)
                {
                    lastCount = divisorCount;
                    Progress = (divisorCount / 501f) * 100;
                }

                current++;
            }
        }

        private int GetTriangleSum(int current)
        {
            return Enumerable.Range(1, current).Sum();
        }

        private int GetDivisorCount(int number)
        {
            int divisors = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    divisors++;

                if (i == number - i + 1)
                    break;

                if (number % number - i + 1 == 0)
                    divisors++;
            }

            return divisors;
        }
    }
}
