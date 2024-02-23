using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class QuickSortAlgorithmTest
    {
        [Fact]
        public void Test01()
        {
            int[] array = { 52, 96, 67, 71, 42, 38, 39, 40, 14 };
            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            QuickSortAlgorithm algo = new();

            int[] answer = { 14, 38, 39, 40, 42, 52, 67, 71, 96 };
            int[] ArraySorted = algo.SortArray(array, leftIndex, rightIndex);

            for(int i =0; i < array.Length; i++)
                Assert.Equal(answer[i], ArraySorted[i]);
        }
    }
}
