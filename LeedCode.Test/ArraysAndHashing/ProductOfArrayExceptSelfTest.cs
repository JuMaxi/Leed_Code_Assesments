using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class ProductOfArrayExceptSelfTest
    {
        [Fact]
        public void Test01()
        {
            ProductOfArrayExceptSelf product = new();

            int[] nums = { 1, 2, 3, 4 };

            int[] expected = { 24, 12, 8, 6 };

            int[] result = product.ProductExceptSelf(nums);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            ProductOfArrayExceptSelf product = new();

            int[] nums = { -1, 1, 0, -3, 3 };

            int[] expected = { 0, 0, 9, 0, 0 };

            int[] result = product.ProductExceptSelf(nums);

            result.Should().BeEquivalentTo(expected);

        }

    }
}
