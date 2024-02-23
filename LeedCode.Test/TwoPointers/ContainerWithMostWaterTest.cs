using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class ContainerWithMostWaterTest
    {
        [Fact]
        public void Test01()
        {
            ContainerWithMostWater most = new();

            int[] heigth = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int n = most.MaxArea(heigth);

            Assert.Equal(49, n);
        }

        [Fact]
        public void Test02()
        {
            ContainerWithMostWater most = new();

            int[] heigth = { 1, 1 };

            int n = most.MaxArea(heigth);

            Assert.Equal(1, n);
        }



    }
}
