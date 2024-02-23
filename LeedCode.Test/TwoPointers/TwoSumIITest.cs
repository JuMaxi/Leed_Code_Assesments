using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class TwoSumIITest
    {
        [Fact]
        public void Test01()
        {
            TwoSumII sum = new();

            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;

            int[] expected = { 1, 2 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            TwoSumII sum = new();

            int[] numbers = { 2, 3, 4 };
            int target = 6;

            int[] expected = { 1, 3 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test03()
        {
            TwoSumII sum = new();

            int[] numbers = { -1, 0 };
            int target = -1;

            int[] expected = { 1, 2 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test04()
        {
            TwoSumII sum = new();

            int[] numbers = { -3, 3, 4, 90 };
            int target = 0;

            int[] expected = { 1, 2 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test05()
        {
            TwoSumII sum = new();

            int[] numbers = { 5, 25, 75 };
            int target = 100;

            int[] expected = { 2, 3 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test06()
        {
            TwoSumII sum = new();

            int[] numbers = { -10, -8, -2, 1, 2, 5, 6 };
            int target = 0;

            int[] expected = { 3, 5 };
            int[] answer = sum.TwoSum(numbers, target);

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
