using System;
using System.Text;

namespace CamelCase
{
    public class StringMethods
    {
        public static string CamelCase(string input)
        {

            var sb = new StringBuilder(input.ToLower());
            sb[0] = Char.ToLower(sb[0]);


            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ' ' || sb[i] == '_' 
                    || sb[i] == '-' || sb[i] == '.')
                {
                    sb.Remove(i, 1);
                    if (i != sb.Length) sb[i] = Char.ToUpper(sb[i]);
                }
            }
            return sb.ToString();

        }


        public static string PascalCase(string input)
        {
            var sb = new StringBuilder(input.ToLower());
            sb[0] = Char.ToUpper(sb[0]);


            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ' ' || sb[i] == '_' 
                    || sb[i] == '-' || sb[i] == '.')
                {
                    sb.Remove(i, 1);
                    if (i != sb.Length) sb[i] = Char.ToUpper(sb[i]);
                }
            }
            return sb.ToString();
        }
    }
}