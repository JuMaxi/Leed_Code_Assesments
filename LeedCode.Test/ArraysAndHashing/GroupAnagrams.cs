using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class GroupAnagrams
    {
        public List<List<string>> GroupAll(string[] strs)
        {
            List<List<string>> anagrams = new();

            Dictionary<int, Dictionary<char, int>> words = SumTotalDigitsForWord(strs);

            for (int i = 0; i < words.Count; i++)
            {
                List<string> list = new();

                for (int ii = i + 1; ii < words.Count; ii++)
                {
                    list = AddAnagramToList(list, i, ii, strs, words);

                    if (list.Contains(strs[words.ElementAt(ii).Key]))
                    {
                        var delete = words.ElementAt(ii);
                        words.Remove(delete.Key);
                        ii--;
                    }
                }

                if (list.Count == 0)
                {
                    var insert = words.ElementAt(i);
                    list.Add(strs[insert.Key]);
                }
                anagrams.Add(list);

            }
            return anagrams;
        }

        private bool VerifyIfItIsAnagram(int i, int ii, Dictionary<int, Dictionary<char, int>> words)
        {
            var actualString = words.ElementAt(i).Value;

            var nextString = words.ElementAt(ii).Value;

            if (actualString.Count == nextString.Count)
            {
                for (int charActualString = 0; charActualString < actualString.Count; charActualString++)
                {
                    var w2 = nextString.ElementAt(charActualString);

                    if (actualString.ContainsKey(w2.Key))
                    {
                        if (nextString[w2.Key] != w2.Value)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        private Dictionary<int, Dictionary<char, int>> SumTotalDigitsForWord(string[] strs)
        {
            Dictionary<int, Dictionary<char, int>> words = new();

            for (int i = 0; i < strs.Length; i++)
            {
                Dictionary<char, int> firstString = new();

                foreach (char c in strs[i])
                {
                    if (firstString.ContainsKey(c))
                    {
                        firstString[c]++;
                    }
                    else
                    {
                        firstString.Add(c, 1);
                    }
                }
                words.Add(i, firstString);
            }
            return words;
        }

        private List<string> AddAnagramToList(List<string> list, int i, int ii, string[] strs, Dictionary<int, Dictionary<char, int>> words)
        {
            bool isAnagram = VerifyIfItIsAnagram(i, ii, words);

            var actual = words.ElementAt(i);
            var next = words.ElementAt(ii);

            if (isAnagram)
            {
                if (!list.Contains(strs[actual.Key]))
                {
                    list.Add(strs[actual.Key]);
                    list.Add(strs[next.Key]);
                }
                else
                {
                    list.Add(strs[next.Key]);
                }
            }
            return list;
        }
    }
}


