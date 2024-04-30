using System.Numerics;

namespace LeedCode.Test.BinarySearch
{
    public class SearchInteger
    {
        public int Search(int[] nums, int target)
        {
            int right = nums.Length - 1;
            int left = 0;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if(target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    if(target < nums[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        return middle;
                    }
                }
            }
            return -1;
        }
    }
}
