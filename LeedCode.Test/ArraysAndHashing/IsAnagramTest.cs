using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class IsAnagramTest
    {
        [Fact]
        public void VerifyIfItIsAnagram()
        {
            IsAnagram isAnagram = new();

            bool verify = isAnagram.VerifyIfItIsAnagram("anagram", "nagaram");

            Assert.True(verify);

            bool verify2 = isAnagram.VerifyIfItIsAnagram("rat", "cat");

            Assert.False(verify2);

        }
    }
}
