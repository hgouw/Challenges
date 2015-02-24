using System;

namespace Challenges
{
    public static class Challenge6
    {
        /// <summary>
        /// Challenge 6
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        /// Count the minimal number of jumps that the small frog must perform to reach its target.
        /// X, Y and D are integers within the range [1..1,000,000,000];
        /// X ≤ Y
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling(((double)Y - (double)X) / (double)D);
        }
    }
}