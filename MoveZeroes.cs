using System;

namespace Array101
{
    public class MoveZeroes
    {
        public void MoveZeroesInPlace(int[] nums)
        {
            int n = nums.Length;
            int writer_ind = 0;
            for (int reader = 0; reader < n; reader++)
            {
                if (nums[reader] != 0)
                {
                    if(writer_ind != reader)
                    {
                        nums[writer_ind] = nums[reader];
                    }
                    
                    writer_ind++;
                }
            }
            for (int i = writer_ind; i < n; i++)
            {
                nums[i] = 0;
            }
        }
    }
}

