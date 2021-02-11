using System;

namespace Primes
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int num)
        {
            
            if (num <= 1) return false;

            int a = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0) a++;
            }

            return a == 2 ? true : false;
        }

        public static int SumOfPrimes(int maxNumber)
        {
            int sum = 0;

            for (int i = 2; i <= maxNumber; i++)
            {
                sum += IsPrime(i) ? i : 0;
            }
            return sum;
        }
    }
}
