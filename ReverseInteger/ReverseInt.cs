using System;

namespace ReverseInteger
{
    public class ReverseInt
    {


        private static double ReverseInteger(int v)
        {
            //to handle negatives
            bool neg = false;
            if (v < 0)
            {
                neg = true;
                v *= -1;
            }

            double rev = 0;
            while (v > 0)
            {
                rev = rev * 10 + v % 10;
                v /= 10;
            }
            return neg == true ? rev * -1 : rev;
        }
    }
}
