using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace LeedCode.Test.ArraysAndHashing
{
    public class TopKFrequentElementsTest
    {
        [Fact]
        public void Test01()
        {
            TopKFrequentElements topK = new();

            int[] nums = { 1, 1, 1, 2, 2, 3 };

            int k = 2;

            int[] expected = { 1, 2 };

            int[] result = topK.TopKFrequent(nums, k);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test02()
        {
            TopKFrequentElements topK = new();

            int[] nums = { 1 };

            int k = 1;

            int[] expected = { 1 };

            int[] result = topK.TopKFrequent(nums, k);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact] 
        public void Test03()
        {
            TopKFrequentElements topK = new();

            int[] nums = { 3, 1, 1, 1, 2, 2 };

            int k = 2;

            int[] expected = { 1,2 };

            int[] result = topK.TopKFrequent(nums, k);

            result.Should().BeEquivalentTo(expected);

        }
        [Fact]
        public void Test04()
        {
            TopKFrequentElements topK = new();
            int[] nums = { -1, -1 };
            int k = 1;

            int[] expected= { -1 };

            int[] result = topK.TopKFrequent(nums, k);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
