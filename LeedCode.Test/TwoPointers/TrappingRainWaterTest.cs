using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class TrappingRainWaterTest
    {
        [Fact]
        public void Test01()
        {
            TrappingRainWater trapping = new();

            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            int sum = trapping.Trap(height);

            Assert.Equal(6, sum);
        }

        [Fact]
        public void Test02()
        {
            TrappingRainWater trapping = new();

            int[] height = { 4, 2, 0, 3, 2, 5 };

            int sum = trapping.Trap(height);

            Assert.Equal(9, sum);
        }

        [Fact]
        public void Test03()
        {
            TrappingRainWater trapping = new();

            int[] height = { 2, 0, 2 };

            int sum = trapping.Trap(height);

            Assert.Equal(2, sum);
        }

        [Fact]
        public void Test04()
        {
            TrappingRainWater trapping = new();

            int[] height = { 2, 1, 0, 2 };

            int sum = trapping.Trap(height);

            Assert.Equal(3, sum);
        }

        [Fact]
        public void Test05()
        {
            TrappingRainWater trapping = new();

            int[] height = {4,2,3 };

            int sum = trapping.Trap(height);

            Assert.Equal(1, sum);
        }

        [Fact]
        public void Test06()
        {
            TrappingRainWater trapping = new();

            int[] height = { 5, 4, 1, 2 };

            int sum = trapping.Trap(height);

            Assert.Equal(1, sum);
        }
    }
}
