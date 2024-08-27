using System;

namespace Array101
{
    public class RemoveElementK
    {
        public int RemoveElementKInPlace(int[] nums, int val)
        {
            int wrt = 0;
            for (int i = 0; i<nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    if(i != wrt)
                    {
                        nums[wrt] = nums[i];
                    }
                    wrt++;
                }
            }
            return wrt;
        }
       
    }
}

