using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class _3SumNew
    {
        //https://leetcode.com/problems/3sum/solutions/441821/c-solution-with-explanations-for-newbies-3
        //I took this solution (link acima) to study.
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> answer = new List<List<int>>();

            if (nums.Length <= 2) { return answer; }

            Array.Sort(nums);

            int start = 0;
            int left = 0;
            int right = 0;
            int target = 0;

            while(start < nums.Length-2)
            {
                left = start + 1;
                right = nums.Length - 1;
                target = nums[start] * -1;

                while(left < right)
                {
                    if (nums[left] + nums[right] > target)
                    {
                        right--;
                    }
                    else
                    {
                        if (nums[left] + nums[right] < target)
                        {
                            left++;
                        }
                        else
                        {
                            List<int> list = new() { nums[start], nums[left], nums[right] };
                            answer.Add(list);

                            while(left < right && nums[left] == list[1])
                            {
                                left++;
                            }
                            while(left < right && nums[right] == list[2])
                            {
                                right--;
                            }
                        }
                    }
                }
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                {
                    start++;
                }
            }
            return answer;
        }

    }
}
