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

            string[] strs1 = { "eat", "tea", "tan", "ate", "nat", "bat" };

            GroupAnagrams groupFeko1 = new();

            string[] strs1Feko1 = { "cat", "act", "tac" };
            var result = groupFeko1.GroupAll(strs1Feko1);


            List<List<string>> expected1 = new()
            {
                new() { "bat" },
                new() { "nat", "tan" },
                new() { "ate", "eat", "tea" }
            };

            List<List<string>> list1 = group.GroupAll(strs1);

            list1.Should().BeEquivalentTo(expected1);


            string[] strs2 = { "" };

            List<List<string>> expected2 = new() { new() { "" } };

            List<List<string>> list2 = group.GroupAll(strs2);

            list2.Should().BeEquivalentTo(expected2);


            string[] strs3 = { "a" };

            List<List<string>> expected3 = new() { new() { "a" } };

            List<List<string>> list3 = group.GroupAll(strs3);

            list3.Should().BeEquivalentTo(expected3);


            string[] strs4 = { "ape", "and", "cat" };

            List<List<string>> expected4 = new()
            {
                new(){"ape"},
                new(){"and"},
                new(){"cat"}
            };

            List<List<string>> list4 = group.GroupAll(strs4);

            list4.Should().BeEquivalentTo(expected4);

            string[] strs5 = { "hhhhu", "tttti", "tttit", "hhhuh", "hhuhh", "tittt" };

            List<List<string>> expected5 = new()
            {
                new(){ "tittt", "tttit", "tttti" },
                new(){"hhhhu","hhhuh","hhuhh"}
            };

            List<List<string>> list5 = group.GroupAll(strs5);

            list5.Should().BeEquivalentTo(expected5);

            string[] strs6 = { "ddddddddddg", "dgggggggggg" };

            List<List<string>> expected6 = new()
            {
                new(){ "ddddddddddg" },
                new(){ "dgggggggggg" }
            };

            List<List<string>> list6 = group.GroupAll(strs6);

            list6.Should().BeEquivalentTo(expected6);
        }
    }
}
