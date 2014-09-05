using System;
using System.Runtime.Serialization;

namespace Challenges
{
    /// <summary>
    /// Custom InvalidTriangleException derived from Exception
    /// </summary>
    [Serializable]
    public sealed class InvalidTriangleException : Exception
    {
        public InvalidTriangleException() : base() { }
        public InvalidTriangleException(string message) : base(message) { }
        public InvalidTriangleException(string message, Exception inner) : base(message, inner) { }
        public InvalidTriangleException(string format, params object[] args) : base(String.Format(null, format, args)) { }
        private InvalidTriangleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// Challenge 3
    /// </summary>
    public static class Challenge3
    {
        /// <summary>
        /// Takes 3 integer inputs representing the sides of a triangle.
        /// Returns the area of the triangle if the inputs are valid, or throw InvalidTriangleException otherwise.
        /// </summary>
        /// <param name="a">Side 1 of the triangle</param>
        /// <param name="b">Side 2 of the triangle</param>
        /// <param name="c">Side 3 of the triangle</param>
        /// <returns></returns>
        public static double TriangleArea(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw (new InvalidTriangleException("One or more of the inputs are negative [{0}, {1}, {2}].", a, b, c));
            }

            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                throw (new InvalidTriangleException("A valid triangle cannot be formed by the inputs [{0}, {1}, {2}].", a, b, c));
            }

            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}