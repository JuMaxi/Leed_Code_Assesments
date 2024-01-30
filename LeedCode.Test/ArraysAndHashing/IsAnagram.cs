using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class IsAnagram
    {
        public bool VerifyIfItIsAnagram(string s, string t)
        {
            // "anagram", "nagaram"

            Dictionary<char, int> totalDigitsS = new();
            Dictionary<char, int> totalDigitsT = new();

            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!totalDigitsS.ContainsKey(s[i]))
                    {
                        totalDigitsS.Add(s[i], 1);
                    }
                    else
                    {
                        totalDigitsS[s[i]]++;
                    }
                }
                for (int i = 0; i < t.Length; i++)
                {
                    if (!totalDigitsT.ContainsKey(t[i]))
                    {
                        totalDigitsT.Add(t[i], 1);
                    }
                    else
                    {
                        totalDigitsT[t[i]]++;
                    }
                }

                for (int index = 0; index < totalDigitsS.Count; index++)
                {
                    var dicS = totalDigitsS.ElementAt(index);

                    if (totalDigitsT.ContainsKey(dicS.Key))
                    {
                        if (totalDigitsT[dicS.Key] != dicS.Value)
                        {
                            return false;
                        }
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
}
