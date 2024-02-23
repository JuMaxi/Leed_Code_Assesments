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
            ValidParentheses valid = new();

            string s = "()";

            bool answer = valid.IsValid(s);

            Assert.True(answer);

        }

        [Fact]
        public void Test02()
        {
            ValidParentheses valid = new();

            string s = "()[]{}";

            bool answer = valid.IsValid(s);

            Assert.True(answer);
        }

        [Fact]
        public void Test03()
        {
            ValidParentheses valid = new();

            string s = "(]";

            bool answer = valid.IsValid(s);

            Assert.False(answer);
        }
    }
}
