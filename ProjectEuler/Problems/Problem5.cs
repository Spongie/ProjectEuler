namespace ProjectEuler.Problems
{
    public class Problem5 : Problem
    {
        private bool IsDividable(int number)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (number % i != 0)
                    return false;
            }

            return true;
        }

        protected override long DoSolutionSolve()
        {
            int current = 1;

            while (true)
            {
                if (IsDividable(current))
                {
                    Progress = 100;
                    return current;
                }

                current++;
            }
        }
    }
}
