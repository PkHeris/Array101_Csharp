using System;

namespace Array101
{
    public class CheckIfExist
    {
        public bool CheckIfExistSatisfied(int[] arr)
        {
            HashSet<int> set = new HashSet<int> ();
            foreach (int num in arr)
            {
                if ( (set.Contains (2 * num)) || ( num % 2 == 0 && set.Contains(num / 2) ))
                {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }
    }
}

