using System.Threading;

namespace ProjectEuler.Problems
{
    public class Problem1 : Problem
    {
        protected override long DoSolutionSolve()
        {
            long total = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    total += i;

                if (i % 10 == 0)
                    Progress += 1;
            }

            return total;
        }
    }
}
