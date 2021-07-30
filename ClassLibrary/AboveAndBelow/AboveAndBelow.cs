using System;

namespace ClassLibrary
{
    public static class AboveAndBelow
    {
        /// <summary>
        ///  Find the number of integers in an array that are above the given input target and the number that are below. 
        ///  (note: numbers that are equal are ignored)
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="i">Input number</param>
        /// <param name="above">The number of elements in inputArray that are above i</param>
        /// <param name="below">The number of elements in inputArray that are below i</param>
        public static void Find(int[] inputArray, int target, out int above, out int below)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException();
            }

            above = 0;
            below = 0;

            foreach (int i in inputArray)
            {
                if (i < target)
                {
                    below++;
                }
                else if (i > target)
                {
                    above++;
                }
            }

        }

    }
}
