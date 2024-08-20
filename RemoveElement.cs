using System;

namespace Array101
{
    public class RemoveElement
    {
        public int RemoveElementbyKtimes(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i< nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}

