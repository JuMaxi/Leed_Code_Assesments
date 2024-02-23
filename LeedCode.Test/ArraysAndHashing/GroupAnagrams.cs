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
        private char[] SortWord(char[] word, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            char pivot = word[leftIndex];

            while (i <= j)
            {
                while (word[i] < pivot)
                {
                    i++;
                }

                while (word[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    char temp = word[i];
                    word[i] = word[j];
                    word[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftIndex < j)
            {
                SortWord(word, leftIndex, j);
            }
            if (rightIndex > i)
            {
                SortWord(word, i, rightIndex);
            }
            return word;
        }


        private Dictionary<string, List<string>> SaveSortedWordToDictionaryIfItIsNotAKey(string word, string sortedWord, Dictionary<string, List<string>> list)
        {
            if (list.ContainsKey(sortedWord))
            {
                list[sortedWord].Add(word);
            }
            else
            {
                List<string> l = new() { word };

                list.Add(sortedWord, l);
            }
            return list;
        }
        public List<List<string>> GroupAll(string[] strs)
        {
            Dictionary<string, List<string>> anagrams = new();

            foreach (string str in strs)
            {
                string sortedWord = "";

                if (str != "")
                {
                    int leftIndex = 0;
                    int rightIndex = str.Length - 1;

                    char[] w = SortWord(str.ToCharArray(), leftIndex, rightIndex);

                    sortedWord = new string(w);
                }

                anagrams = SaveSortedWordToDictionaryIfItIsNotAKey(str, sortedWord, anagrams);
            }

            List<List<string>> list = SaveAnagramsToList(anagrams);

            return list;
        }

        private List<List<string>> SaveAnagramsToList(Dictionary<string, List<string>> anagrams)
        {
            List<List<string>> list = new();

            foreach (string key in anagrams.Keys)
            {
                List<string> l = new();

                foreach (string word in anagrams[key])
                {
                    l.Add(word);
                }
                list.Add(l);
            }
            return list;
        }
    }
}


