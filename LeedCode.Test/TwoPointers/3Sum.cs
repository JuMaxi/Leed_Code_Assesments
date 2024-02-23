using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class _3Sum
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new();
            bool isnotzero = nums.Where(x => x != 0).Any();

            if (nums.Sum() == 0 && nums.Length == 3
                || nums.Sum() == 0 && !isnotzero)
            {
                result.Add(new List<int>() { nums[0], nums[1], nums[2] });
                return result;
            }

            var sorted = Sortarray(nums, 0, nums.Length - 1);

            var triplets = Threesum(sorted, 0, nums.Length - 1);

            foreach (var item in triplets)
            {
                result.Add(new List<int>() { item.Item1, item.Item2, item.Item3 });
            }
            return result;
        }

        private HashSet<(int, int, int)> Threesum(int[] sortedarray, int left, int right)
        {
            // scenario: primeira e ultima
            HashSet<(int, int, int)> sum3 = new();
            if (left >= right)
                return sum3;

            int middleposition = (left + right) / 2;
            int valueseeked = (sortedarray[left] + sortedarray[right]) * -1;

            while (middleposition > left && sortedarray[middleposition - 1] == sortedarray[middleposition])
                middleposition--;

            HashSet<int> historymiddlepositions = new();

            while (middleposition > left && middleposition < right)
            {
                if (historymiddlepositions.Contains(middleposition))
                    break;

                historymiddlepositions.Add(middleposition);

                if (sortedarray[middleposition] == valueseeked)
                {
                    sum3.Add((sortedarray[left], sortedarray[middleposition], sortedarray[right]));
                    middleposition++;
                }
                else
                {
                    if (sortedarray[middleposition] < valueseeked)
                    {
                        middleposition++;
                    }
                    else
                    {
                        middleposition--;
                    }
                }
            }

            // scenario: primeira e penultima
            var resulta = Threesum(sortedarray, left, right - 1);

            // scenario: segunda e ultima
            var resultb = Threesum(sortedarray, left + 1, right);

            // repete: segunda e penultima
            var resultc = Threesum(sortedarray, left + 1, right - 1);
            sum3 = sum3.Union(resulta).Union(resultb).Union(resultc).ToHashSet();

            return sum3;
        }


        private int[] Sortarray(int[] nums, int leftindex, int rightindex)
        {
            int i = leftindex;
            int j = rightindex;
            int pivot = nums[leftindex];

            while (i <= j)
            {
                while (nums[i] < pivot)
                {
                    i++;
                }
                while (nums[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftindex < j)
            {
                Sortarray(nums, leftindex, j);
            }
            if (rightindex > i)
            {
                Sortarray(nums, i, rightindex);
            }
            return nums;
        }



    }
}
