using System;

namespace StringEndsWith
{
    public class EndsWIth
    {
        public static bool Solution(string str, string ending)
        {
            int i = str.Length - 1;
            int j = ending.Length - 1;

            if (j > i) return false;

            while (j >= 0)
            {
                if (str[i] != ending[j]) return false;
                i--;
                j--;
            }
            return true;
        }
    }
}
