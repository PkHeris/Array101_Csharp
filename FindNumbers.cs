using System;

namespace Array101
{
    public class FindNumbers
    {
        public int FindNumbersWithEvenDigits(int[] nums) 
        {
            int result = 0;
            foreach (int num in nums)
            {
                if (HasEvenNumberOfDigits(num))
                {
                    result++;
                }
            }
            return result;
        }

        private bool HasEvenNumberOfDigits(int num)
        {
            if (num == 0) return false;
            int digitCount = 0;
            while (num != 0)
            {
                num /= 10;
                digitCount++;
            }

            return digitCount % 2 == 0;
        }
    }
}