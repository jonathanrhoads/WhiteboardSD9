using System;

namespace LetterSwap
{
    public class LetterSwap
    {
        public static string Switcheroo(string x)
        {
            string s = "";
            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] == 'a') s += 'b';
                else if (x[i] == 'b') s += 'a';
                else s += x[i];
            }
            return s;
        }
    }
}
