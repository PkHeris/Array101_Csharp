using System;

namespace Array101
{
    public class HeightChecker
    {
        public int HeightCheckerDiff(int[] heights)
        {
            int[] expectedHeights = (int[])heights.Clone();
            Array.Sort(expectedHeights);
            int count = 0;
            for(int i = 0; i<heights.Length; i++)
            {
                if (heights[i] != expectedHeights[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
