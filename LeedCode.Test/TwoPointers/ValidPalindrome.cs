using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (s.Length <= 1) { return true; }
            bool result = TwoPointers(s);

            return result;
        }
        private string ConvertingToLowerCaseAndTakingOffNonAlphanumericCharacters(string s)
        {
            s = s.ToLower();

            string newS = "";

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    newS += c;
                }
            }

            return newS;
        }

        private bool TwoPointers(string s)
        {
            s = ConvertingToLowerCaseAndTakingOffNonAlphanumericCharacters(s);

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
