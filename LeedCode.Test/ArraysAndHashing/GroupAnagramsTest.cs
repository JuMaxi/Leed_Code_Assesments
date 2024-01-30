using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class GroupAnagramsTest
    {
        [Fact]
        public void Test01()
        {
            GroupAnagrams group = new();

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            List<List<string>> expected = new() 
            { 
                new() { "bat" },
                new() { "nat", "tan" },
                new() { "ate", "eat", "tea" }
            };

            List<List<string>> list = group.GroupAll(strs);
            
            list.Should().BeEquivalentTo(expected);
             
        }
    }
}
