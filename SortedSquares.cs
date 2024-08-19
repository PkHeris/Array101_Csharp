using System;

namespace Array101
{
    public class SortedSquares
    {
        public int[] SortedSquaresNumbersHigherComplexity(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 2);
            }
            Array.Sort(nums);

            return nums;
        }

        public int[] SortedSquaresNumbersLowerComplexity(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int left = 0, right = n-1, index = n-1;
            while (left <= right)
            {
                int leftsquare = nums[left] * nums[left];
                int rightsquare = nums[right] * nums[right];
                if (leftsquare > rightsquare)
                {
                    result[index] = leftsquare;
                    left++;
                }
                else
                {
                    result[index]=rightsquare;
                    right--;
                }
                index--;
            }

            return result;
        }

    }
}
