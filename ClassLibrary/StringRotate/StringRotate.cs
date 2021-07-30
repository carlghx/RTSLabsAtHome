using System;

namespace ClassLibrary
{
    public static class StringRotate
    {
        /// <summary>
        /// Rotates a string s by moving the first n characters from the beginning to the end
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Rotate(string s, int n)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }

            if (n > s.Length || n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var left = s.Substring(0, s.Length - n);
            var right = s.Substring(s.Length - n);

            return right + left;
        }

    }
}
