using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem2 : Problem
    {
        public IEnumerable<int> Fibonacci()
        {
            int first = 1;
            int second = 2;

            yield return first;
            yield return second;

            while (true)
            {
                int next = first + second;
                first = second;
                second = next;
                yield return next;
            }
        }

        protected override long DoSolutionSolve()
        {
            var numbers = new List<int>();

            foreach (var number in Fibonacci())
            {
                if (number > 4000000)
                    break;

                if (number % 2 == 0)
                    numbers.Add(number);
            }

            Progress = 100;
            return numbers.Sum();
        }
    }
}
