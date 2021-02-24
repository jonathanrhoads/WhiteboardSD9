using System;

namespace RotateArray
{
    public class Rotate
    {
        static int[] rotateArray(string dir, int dis, int[] nums)
        {
            if (dir == "left") dis = -dis;
            return rotateArray(dis, nums);
        }

        static int[] rotateArray(int dis, int[] nums)
        {
            int[] rotated = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                int newIdx = i + dis;
                if (newIdx > nums.Length) newIdx -= nums.Length;
                else if (newIdx < 0) newIdx += nums.Length;
                rotated[i] = nums[newIdx % nums.Length];
            }

            return rotated;
        }
    }
}
