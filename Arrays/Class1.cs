using System;

namespace Arrays
{
    public class Class1
    {
        //public static string TurnToCSVString(int[] arr) => string.Join(",", arr);

        public static string TurnToCSVString(int[] arr)
        {
            string csv = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                csv += arr[i] + ",";
            }

            csv += arr[arr.Length - 1];

            return csv;
        }
    }
}
