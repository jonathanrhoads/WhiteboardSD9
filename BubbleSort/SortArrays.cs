using System;

namespace Sorting
{
    public class SortArrays
    {
        public static void swap(int i, int j, int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static int[] bubbleSort(int[] nums)
        {
            bool isSorted = false;
            int count = 0;

            while (!isSorted)
            {
                isSorted = true;

                for(int i = 0; i < nums.Length - 1 - count; i++)
                {
                    if(nums[i] > nums[i + 1])
                    {
                        swap(i, i + 1, nums);
                        isSorted = false;
                    }
                }
                count++;
            }

            return nums;
        }
       
    }
}
