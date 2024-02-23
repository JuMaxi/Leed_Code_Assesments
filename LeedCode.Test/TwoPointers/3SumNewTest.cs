using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class _3SumNewTest
    {
        [Fact]
        public void Test01()
        {
            _3SumNew sum = new();

            int[] nums = { -1, 0, 1, 2, -1, -4 };
            
            List<List<int>> expected = new()
            {
                new(){ -1, -1, 2 },
                new(){ -1, 0, 1 }
            };
            List<List<int>> list = sum.ThreeSum(nums);

            list.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public void Test02()
        {
            _3SumNew sum = new();

            int[] nums = { 0, 1, 1 };

            List<List<int>> expected = new();

            List<List<int>> list = sum.ThreeSum(nums);

            list.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test03()
        {
            _3SumNew sum = new();

            int[] nums = { 0, 0, 0 };

            List<List<int>> expected = new() { new() { 0, 0, 0 } };

            List<List<int>> list = sum.ThreeSum(nums);

            list.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test04()
        {
            _3SumNew sum = new();

            int[] nums = { -1, 0, 1 };

            List<List<int>> expected = new() { new() { -1, 0, 1 } };

            List<List<int>> list = sum.ThreeSum(nums);

            list.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test05()
        {
            _3SumNew sum = new();

            int[] nums = { 0, 0, 0, 0 };

            List<List<int>> expected = new() { new() { 0, 0, 0 } };

            List<List<int>> list = sum.ThreeSum(nums);

            list.Should().BeEquivalentTo(expected);
        }
    }
}
