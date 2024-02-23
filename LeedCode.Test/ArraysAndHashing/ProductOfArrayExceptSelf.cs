using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] sum1 = new int[nums.Length];
            sum1[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum1[i] = sum1[i - 1] * nums[i];
            }

            int[] sum2 = new int[nums.Length];
            sum2[nums.Length - 1] = nums[nums.Length - 1];

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                sum2[i] = sum2[i + 1] * nums[i];
            }

            nums[0] = sum2[1];
            nums[nums.Length - 1] = sum1[nums.Length - 2];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                nums[i] = sum1[i - 1] * sum2[i + 1];
            }

            return nums;
        }
    }
}
