using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.Stack
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void Test01()
        {
            string s = "()";

            ValidParentheses valid = new();

            bool answer = valid.IsValid(s);

            Assert.True(answer);

        }

        [Fact]
        public void Test02()
        {
            string s = "()[]{}";

            ValidParentheses valid = new();

            bool answer = valid.IsValid(s);

            Assert.True(answer);
        }

        [Fact]
        public void Test03()
        {
            string s = "(]";

            ValidParentheses valid = new();

            bool answer = valid.IsValid(s);

            Assert.False(answer);
        }

        [Fact]
        public void Test04()
        {
            string s = "((";

            ValidParentheses valid = new();

            bool answer = valid.IsValid(s);

            Assert.False(answer);
        }

        [Fact]
        public void Test05()
        {
            string s = "){";

            ValidParentheses valid = new();

            bool answer = valid.IsValid(s);

            Assert.False(answer);
        }
    }
}
