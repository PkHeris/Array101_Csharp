using System;

namespace Array101
{
    public class FindMaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnesMethod(int[] nums)
        {
            int current_count = 0;
            int max_count = 0;

            foreach (int num in nums)
            {
                if (num == 1)
                {
                    current_count++;
                    max_count = Math.Max(max_count, current_count);
                }
                else
                {
                    current_count = 0;
                }
            }

            return max_count;
        }
    }
}