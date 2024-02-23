using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class LongestConsecutiveTest
    {
        [Fact]
        public void Test01()
        {
            LongestConsecutive longest = new();

            int[] nums = { 100, 4, 200, 1, 3, 2 };

            int result = longest.LongestConsecutiveResolution(nums);

            Assert.Equal(4, result);
        }
        [Fact]
        public void Test02()
        {
            LongestConsecutive longest = new();

            int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            int result = longest.LongestConsecutiveResolution(nums);

            Assert.Equal(9, result);
        }

        [Fact]
        public void Test03()
        {
            LongestConsecutive longest = new();

            int[] nums = { 1, 2, 0, 1 };


            int result = longest.LongestConsecutiveResolution(nums);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test04()
        {
            LongestConsecutive longest = new();

            int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };


            int result = longest.LongestConsecutiveResolution(nums);

            Assert.Equal(7, result);
        }
    }
}
