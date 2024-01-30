using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSumTarget()
        {
            TwoSum twoSum = new();

            int[] nums = { 2, 7, 11, 15 };
            int[] result1 = twoSum.TwoSumTarget(nums, 9);
            Assert.Equal(0, result1[0]);
            Assert.Equal(1, result1[1]);

            int[] nums2 = { 3, 2, 4 };
            int[] result2 = twoSum.TwoSumTarget(nums2, 6);
            Assert.Equal(1, result2[0]);
            Assert.Equal(2, result2[1]);

            int[] nums3 = { 3, 3 };
            int[] result3 = twoSum.TwoSumTarget(nums3, 6);
            Assert.Equal(0, result3[0]);
            Assert.Equal(1, result3[1]);

        }
    }
}
