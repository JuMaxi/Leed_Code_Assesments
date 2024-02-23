using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class TwoSum
    {
        public int[] TwoSumTarget(int[] nums, int target)
        {
            int[] result = new int[2];

            int next = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[next] + nums[i] == target)
                {
                    result[0] = next;
                    result[1] = i;
                    break;
                }
                else
                {
                    if (i == nums.Length - 1)
                    {
                        i = next + 1;
                        next++;
                    }
                }
            }

            return result;
        }
    }
}
