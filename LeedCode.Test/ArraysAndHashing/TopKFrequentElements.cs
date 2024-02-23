using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class TopKFrequentElements
    {
        private Dictionary<int, int> TakeTimesNumberAppear(int[] nums)
        {
            Dictionary<int, int> dict = new();

            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            return dict;
        }
        private (int e, int q)[] SaveDictionaryToTupla(int[] nums)
        {
            Dictionary<int, int> dict = TakeTimesNumberAppear(nums);

            (int element, int quantity)[] numbers = new (int, int)[dict.Count];

            for (int i = 0; i < dict.Count; i++)
            {
                var actual = dict.ElementAt(i);
                numbers[i] = (actual.Key, actual.Value);
            }
            return numbers;
        }
        private (int e, int q)[] SortArray((int element, int quantity)[] numbers, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = numbers[leftIndex].Item2;

            while (i <= j)
            {
                while (numbers[i].Item2 < pivot)
                {
                    i++;
                }
                while (numbers[j].Item2 > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    (int e, int q) temp = numbers[i];

                    numbers[i] = numbers[j];

                    numbers[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftIndex < j)
            {
                SortArray(numbers, leftIndex, j);
            }
            if (rightIndex > i)
            {
                SortArray(numbers, i, rightIndex);
            }

            return numbers;
        }

        public int[] TopKFrequent(int[] nums, int k)
        {

            if (nums.Length > 1)
            {
                (int element, int quantity)[] numbers = SaveDictionaryToTupla(nums);

                if(numbers.Length > 1)
                {
                    int leftIndex = 0;
                    int rightIndex = numbers.Length - 1;

                    numbers = SortArray(numbers, leftIndex, rightIndex);
                }

                int t = 0;
                int[] topKFrequent = new int[k];
                int lastIndex = numbers.Length - 1;

                while (t < k)
                {
                    topKFrequent[t] = numbers[lastIndex].element;
                    lastIndex--;
                    t++;
                }
                return topKFrequent;
            }

            return nums;
        }
    }
}
