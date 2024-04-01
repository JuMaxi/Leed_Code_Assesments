using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack
{
    public class GenerateParenthesesTest
    {
        [Fact]
        public void Test03()
        {
            GenerateParentheses generate = new();

            List<string> answer = generate.GenerateParenthesis(3);

            List<string> expected = new() { "((()))", "(()())", "(())()", "()(())", "()()()" };

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test02()
        {
            GenerateParentheses generate = new();

            List<string> answer = generate.GenerateParenthesis(2);

            List<string> expected = new() { "(())", "()()" };

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test01()
        {
            GenerateParentheses generate = new();

            List<string> answer = generate.GenerateParenthesis(1);

            List<string> expected = new() { "()" };

            Assert.Equal(expected, answer);

        }
    }
}
