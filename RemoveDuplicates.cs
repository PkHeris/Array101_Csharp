using System;

namespace Array101
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicatesReportUnique(int[] nums) 
        {
            int writer_index = 1;
            int n = nums.Length;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[writer_index] = nums[i];
                    writer_index++;
                }
            }
            return writer_index;
            
        }
    }
}