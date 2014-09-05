using System;

namespace Challenges
{
    /// <summary>
    /// Challenge 1
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Returns a true if the value of this instance is null or empty, or a false otherwise.
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
        {
            return ((str == null) || (str == ""));
        }
    }
}