using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class ValidPalindromeTest
    {
        [Fact]
        public void Test01()
        {
            ValidPalindrome valid = new();

            string s = "A man, a plan, a canal: Panama";

            bool result = valid.IsPalindrome(s);

            Assert.True(result);
        }

        [Fact]
        public void Test02()
        {
            ValidPalindrome valid = new();

            string s = "race a car";

            bool result = valid.IsPalindrome(s);

            Assert.False(result);
        }

        [Fact]
        public void Test03()
        {
            ValidPalindrome valid = new();

            string s = "Radar";

            bool result = valid.IsPalindrome(s);

            Assert.True(result);
        }

        [Fact]
        public void Test04()
        {
            ValidPalindrome valid = new();

            string s = "02022020";

            bool result = valid.IsPalindrome(s);

            Assert.True(result);
        }
    }
}
