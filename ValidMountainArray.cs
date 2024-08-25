using System;

namespace Array101
{
    public class ValidMountainArray
    {
        public bool ValidMountainArrayExist(int[] nums)
        {
            int n = nums.Length;

            if (n < 3) { return false; }
            int peak_ind = 0;
            for(int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i-1])
                {
                    peak_ind++;
                }
                else { break; }
            }
            if(peak_ind == 0 || peak_ind == n - 1) { return false; }

            for (int i = peak_ind + 1; i < n; i++)
            {
                if (nums[i] >= nums[i - 1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}

