using System;

namespace Array101
{
    public class ValidMountainArray
    {
        public bool ValidMountainArrayExist(int[] nums)
        {
            int n = nums.Length;
            int right_to_left = 0;
            int left_to_right = n-1;
            bool increase_left = true;
            int potential_hill = 0;
            if (n < 3)
            {
                return false;
            }
            while (increase_left)
            {
                if (right_to_left >= n - 1)
                    increase_left = false;
                    return false;
                if (nums[right_to_left + 1 ] > nums[right_to_left])
                {
                    right_to_left++;
                }
                else if (nums[right_to_left + 1] == nums[right_to_left])
                {
                    increase_left = false;
                    return false;
                }
                else if (nums[right_to_left + 1] < nums[right_to_left])
                {
                    potential_hill = right_to_left;
                    increase_left = false;
                }
            }
            if (potential_hill != 0)
            {
                for (int i = left_to_right; i > potential_hill; i--)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
            return false;

        }
    }
}

