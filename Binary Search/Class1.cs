using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        private static int BinarySearch(int[] list, int tgt)
        {
            //iterative approach
            int left = 0;
            int right = list.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2; // is this better? --> left + (right - left) / 2;
                if (list[mid] == tgt) return mid; // returns index --> change to return list[mid] for value.
                else if (list[mid] < tgt)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }

            return -1; //if no match 
        }

        private static int BisectionAlgorithm(int[] list, int tgt)
        {
            //recurive approach
            return BisectionAlgorithm(list, tgt, 0, list.Length - 1);
        }

        private static int BisectionAlgorithm(int[] list, int tgt, int left, int right)
        {
            if (left > right) return -1;

            int mid = (left + right) / 2;
            int possibleTgt = list[mid];
            if (possibleTgt == tgt) return mid;
            else if (possibleTgt < tgt) return BisectionAlgorithm(list, tgt, mid + 1, right);
            else return BisectionAlgorithm(list, tgt, left, mid - 1);
        }
    }
}
