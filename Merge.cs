using System;

namespace Array101
{
    public class Merge
    {
        public void MergeTwoGroups(int[] nums1, int m, int[] nums2, int n)
        {

            int last1 = m - 1;
            int last2 = n - 1;
            int i = m + n - 1;
            while (last1 >=0 && last2 >=0)
            {
                if (nums1[last1] >= nums2[last2])
                {
                    nums1[i] = nums1[last1];
                    last1--;
                }
                else
                {
                    nums1[i] = nums2[last2];
                    last2--;
                }
                i--;
            }
            while (last2 >=0)
            {
                nums1[i] = nums2[last2];
                i--;
                last2--;
            }

        }
    }
}