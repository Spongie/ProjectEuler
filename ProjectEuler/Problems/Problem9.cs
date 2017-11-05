using System;

namespace ProjectEuler.Problems
{
    public class Problem9 : Problem
    {
        protected override long DoSolutionSolve()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 2; b < 1000; b++)
                {
                    for (int c = 3; c < 1000; c++)
                    {
                        if (a + b + c != 1000)
                            continue;

                        if (a * a + b * b == c * c)
                        {
                            Progress = 100;
                            return a * b * c;
                        }
                    }
                }
            }

            throw new Exception("You suck");
        }
    }
}
