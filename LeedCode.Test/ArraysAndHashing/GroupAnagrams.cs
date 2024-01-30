using System;
using System.Collections.Generic;
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

            for (int i = 0; i < words.Count; i++)
            {
                var acualString = words.ElementAt(i).Value;

                List<string> list = new();

                for (int ii = i + 1; ii < words.Count; ii++)
                {
                    bool sameDigits = true;

                    var nextString = words.ElementAt(ii).Value;

                    for (int charActualString = 0; charActualString < acualString.Count; charActualString++)
                    {
                        var t = acualString.ElementAt(charActualString);

                        if (nextString.ContainsKey(t.Key))
                        {
                            if (nextString[t.Key] != t.Value)
                            {
                                sameDigits = false;
                                break;
                            }
                        }
                        else
                        {
                            sameDigits = false;
                            break;
                        }
                    }

                    if (sameDigits)
                    {
                        if (!list.Contains(strs[i]))
                        {
                            list.Add(strs[i]);
                            list.Add(strs[ii]);
                        }
                        else
                        {
                            list.Add(strs[ii + list.Count-1]);
                        }
                        var batata = words.ElementAt(ii);
                        words.Remove(batata.Key);

                        ii--;
                    }
                }
                anagrams.Add(list);
            }

            return anagrams;
        }
    }
}
