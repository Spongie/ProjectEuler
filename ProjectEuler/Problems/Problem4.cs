using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem4 : Problem
    {
        private bool IsPalindrom(int number)
        {
            var numberString = number.ToString();

            int start = 0;
            int end = numberString.Length - 1;

            while (start <= end)
            {
                if (start == end)
                    return numberString[start] == numberString[end];
                if (numberString[start] != numberString[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }

        protected override long DoSolutionSolve()
        {
            var palindromes = new List<int>();

            for (int first = 100; first < 1000; first++)
            {
                for (int second = 100; second < 1000; second++)
                {
                    if (IsPalindrom(first * second))
                        palindromes.Add(first * second);
                }

                Progress += 0.12f;
            }

            return palindromes.Max();
        }
    }
}
