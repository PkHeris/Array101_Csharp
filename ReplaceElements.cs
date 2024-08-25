using System;

namespace Array101
{
    public class ReplaceElements
    {
        public int[] ReplaceElementsInPlace(int[] arr)
        {

            int n = arr.Length;
            int MaxRight = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                int currect_val = arr[i];
                arr[i] = MaxRight;
                if (currect_val > MaxRight)
                {
                    MaxRight = currect_val;
                }
            }

            return arr;
        }
    }
}

