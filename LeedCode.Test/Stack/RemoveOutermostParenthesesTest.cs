using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack
{
    public class RemoveOutermostParenthesesTest
    {
        [Fact]
        public void Test01()
        {
            RemoveOutermostParentheses remove = new();

            string answer = remove.RemoveOuterParentheses("(()())(())");

            string expected = "()()()";

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test02()
        {
            RemoveOutermostParentheses remove = new();

            string answer = remove.RemoveOuterParentheses("(()())(())(()(()))");

            string expected = "()()()()(())";

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test03()
        {
            RemoveOutermostParentheses remove = new();

            string answer = remove.RemoveOuterParentheses("()()");

            string expected = "";

            Assert.Equal(expected, answer);
        }
    }
}
