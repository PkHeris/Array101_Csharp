using System;

namespace Array101
{
    public class SortedSquares
    {
        public int[] SortedSquaresNumbers(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 2);
            }
            Array.Sort(nums);

            return nums;
        }
    }
}
