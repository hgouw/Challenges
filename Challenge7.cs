using System.Collections;

namespace Challenges
{
    public static class Challenge7
    {
        /// <summary>
        /// Challenge 7
        /// The function returns an intersection of two arrays, i.e., an array that contains the elements met in both arrays.
        /// Both input arrays are sorted which contain unique elements.
        /// </summary>
        /// <param name="arrA">First array</param>
        /// <param name="arrB">Second array</param>
        /// <returns>An array containing the common elements of both input arrays</returns>
        public static int[] Intersection(int[] arrA, int[] arrB)
        {
            if ((arrA == null) || (arrB == null) || (arrA.Length == 0) || (arrB.Length == 0))
                return new int[0];

            ArrayList retArray = new ArrayList();
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == arrB[j])
                        retArray.Add(arrA[i]);
                }
            }

            return (int[])retArray.ToArray(typeof(int));
        }

        /// <summary>
        /// The function returns a true if the input arrays have identical elements or false otherwise.
        /// </summary>
        /// <param name="arrA">First array</param>
        /// <param name="arrB">Second array</param>
        /// <returns>True if both are input arrays have identical elements or False otherwise</returns>
        public static bool CompareArrays(int[] arrA, int[] arrB)
        {
            if (arrA.Length != arrB.Length)
                return false;

            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] != arrB[i])
                    return false;
            }

            return true;
        }
    }
}