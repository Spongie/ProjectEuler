﻿using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public static class ProblemUtilities
    {
        private static bool IsPrime(int number)
        {
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static IEnumerable<int> Primes()
        {
            int number = 3;
            yield return 2;

            while (true)
            {
                if (IsPrime(number))
                {
                    yield return number;
                }

                number++;
            }
        }
    }
}
