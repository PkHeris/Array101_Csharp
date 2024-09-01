using System;
using System.Collections.Generic;

namespace Array101
{
    public class ThirdMax
    {
        public int ThirdMaxNonInPlace(int[] nums)
        {
            HashSet<int> nums2UniqueSet = new HashSet<int>(nums);
            List<int> uniqueList = new List<int>(nums2UniqueSet);
            uniqueList.Sort();
            uniqueList.Reverse();
            if(uniqueList.Count < 3)
            {
                return uniqueList[0];
            }
            else
            {
                return uniqueList[2];
            }
        }



        public int ThirdMaxOptimzed(int[] nums)
        {
            if(nums.Length == 0 || nums == null)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int? first = null;
            int? second = null;
            int? third = null;

            foreach( int num in nums)
            {
                if (num == first || num == second || num == third)
                {
                    continue;
                }

                if(first == null || num > first)
                {
                    third = second;
                    second = first;
                    first = num;
                }
                else if(second == null || num > second)
                {
                    third = second;
                    second = num;
                }
                else if (third == null || num > third)
                {
                    third = num;
                }
            }

            return third ?? first.Value;
        }
    }
}

