using System;
using System.Linq;

namespace Challenges
{
    /// <summary>
    /// Challenge 4
    /// </summary>
    public static class Challenge4
    {
        /// <summary>
        /// Takes an array integers.
        /// Returns the integers which are the most common in the input array.
        /// </summary>
        /// <param name="integers">An array of integers</param>
        /// <returns></returns>
        public static int[] Common(int[] integers)
        {
            if (integers.Count() == 0) return new int[] { };
            var lookup = integers.ToLookup(x => x);
            var maxCount = lookup.Max(x => x.Count());
            var result = (lookup.Where(x => x.Count() == maxCount).Select(x => x.Key));
            return result.ToArray();
        }
    }
}