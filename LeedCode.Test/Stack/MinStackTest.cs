using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack
{
    public class MinStackTest
    {
        [Fact]
        public void Test01()
        {
            MinStackSolution solution = new();

            string[] commands = { "MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin" };
            int[] ints = { 0, -2, 0, -3, 0, 0, 0, 0 }; 
                

            string[] expected = { null, null, null, null, "-3", null, "0", "-2" };

            string[] answer = solution.TakeValuesStack(ints, commands);

            answer.Should().BeEquivalentTo(expected);
        }
    }
}
