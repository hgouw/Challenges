using System;
using System.Collections.Generic;

namespace Challenges
{
    /// <summary>
    /// Challenge 2
    /// </summary>
    public static class Challenge2
    {
        /// <summary>
        /// Takes a single positive integer.
        /// Returns an enumeration of integers which are positive divisors of the input integer.
        /// </summary>
        /// <param name="x">A positive integer</param>
        /// <returns></returns>
        public static IEnumerable<uint> PositiveDivisors(uint x)
        {
            uint max = x / 2;
            for (uint i = 1; i <= max; i++)
            {
                if (0 == (x % i))
                {
                    yield return i;
                }
            }
            yield return x;
        }
    }
}