using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem14 : Problem
    {
        private List<long> GetCollatzSequence(long number)
        {
            var sequence = new List<long>();
            
            while (number > 1)
            {
                sequence.Add(number);

                if ( number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = (number * 3) + 1;
                }
            }

            sequence.Add(number);

            return sequence;
        }

        protected override long DoSolutionSolve()
        {
            int maxSequenceNumber = 0;
            int maxNumber = 0;

            for(int i = 1; i < 1000000; i++)
            {
                var sequence = GetCollatzSequence(i);

                if(sequence.Count >= maxSequenceNumber)
                {
                    maxSequenceNumber = sequence.Count;
                    maxNumber = i;
                }

                Progress += 0.0001f;
            }

            Progress = 100f;

            return maxNumber;
        }
    }
}
