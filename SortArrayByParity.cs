using System;

namespace Array101
{
    public class SortArrayByParity
    {
        public void SortArrayByParityInPlace(int[] nums)
        {
            int n = nums.Length;
            int l = 0;
            for (int r = 0;  r < n; r++)
            {
                if ((nums[r] % 2)==0)
                {
                    int temp = nums[r];
                    nums[r] = nums[l];
                    nums[l] = temp;
                    l++;
                }
            }
        }
    }
}