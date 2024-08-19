using System;

namespace Array101
{
    public class DuplicateZeros
    {
        public void DuplicateZerosInPlace(int[] arr)
        {
            int n = arr.Length;
            int count_zero = 0;

            foreach (int i in arr)
            {
                if (i == 0)
                {
                    count_zero++;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (i + count_zero < n)
                {
                    arr[i + count_zero] = arr[i];
                }
                if (arr[i] == 0)
                {
                    count_zero--;
                    if (i + count_zero < n)
                    {
                        arr[i + count_zero] = 0;
                    }
                }
            }
        }
    }
}
