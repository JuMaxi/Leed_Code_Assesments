using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class ContainsDuplicate
    {
        //Time exceeded.
        private int[] SortArray()
        {
            //int[] nums = { 1, 2, 3, -1 };
            //int[] nums = { 1, 1, 1, 3, 3, -4, 3, 2, 4, 2 };
            //int[] nums = { -1, -2, 3, 4 };
            int[] nums = { 50, 1, 50, 2, 50, 10, 40, 1, 40, 2, 40, 3, -30, 1, -30, 2, -30, 11 };
            //int[] nums = { 2048, 0 };
            long sum = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int number = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = number;

                    if (i > 0)
                    {
                        int t = 1;
                        if (i == 1) { t = 0; };
                        if (sum / (i - t) + sum % (i - t) > nums[i])
                        {
                            sum = sum - nums[i];
                            i -= 2;
                        }
                    }
                }
                if (i >= 0)
                {
                    sum += nums[i];
                }
            }

            return nums;
        }

        //Time exceeded.
        private bool VerifyIfContainsDuplicatedNumber()
        {
            int[] nums = SortArray();

            if (nums.Length == 1) { return false; }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }

            return false;
        }
        public bool VerifyIfContainsDuplicatedNumberWithDictionary()
        {
            int[] nums = { 50, 1, 50, 2, 50, 10, 40, 1, 40, 2, 40, 3, -30, 1, -30, 2, -30, 11 };
            Dictionary<int, int> numbers = new();

            foreach (int n in nums)
            {
                if (!numbers.ContainsKey(n))
                {
                    numbers.Add(n, n);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
