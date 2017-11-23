using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class Problem15 : Problem
    {
        const long width = 20;
        const long height = 20;

        long[,] paths = new long[width + 1, height + 1];

        public long latticaPath(int x, int y, long accumulator)
        {
            if(y < height && x < width && paths[x, y] > 0)
                return accumulator + paths[x, y];

            if(x < width && y < height)
            {
                var yAcc = latticaPath(x, y + 1, accumulator);
                var xAcc = latticaPath(x + 1, y, accumulator);

                paths[x, y] += xAcc + yAcc + accumulator;

                return xAcc + yAcc + accumulator;
            }
            else if(x < width)
            {
                var xAcc = latticaPath(x + 1, y, accumulator);
                paths[x, y] += xAcc + accumulator;
                return xAcc + accumulator;
            }
            else if(y < height)
            {
                var yAcc = latticaPath(x, y + 1, accumulator);
                paths[x, y] += yAcc + accumulator;
                return yAcc + accumulator;
            }
            else
                return accumulator + 1;
        }

        protected override long DoSolutionSolve()
        {
            var result = latticaPath(0, 0, 0);
            Progress = 100;
            return result;
        }
    }
}
