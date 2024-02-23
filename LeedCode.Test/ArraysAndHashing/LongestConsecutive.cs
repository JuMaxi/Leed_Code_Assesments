using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class LongestConsecutive
    {
        public int LongestConsecutiveResolution(int[] nums)
        {
            if(nums.Length == 0) return 0;
            return TakeGreaterSequence(nums);
        }
        
        private HashSet<int> TakeUniqueInts(int[] nums)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach(int num in nums)
            {
                uniqueNumbers.Add(num);
            }
            return uniqueNumbers;
        }

        private int TakeGreaterSequence(int[] nums)
        {
            HashSet<int> uniqueNumbers = TakeUniqueInts(nums);

            int longest = 0;
            int greater = 0;

            foreach(int number in uniqueNumbers)
            {
                if (!uniqueNumbers.Contains(number - 1))
                {
                    greater = 1;

                    while (uniqueNumbers.Contains(number + greater))
                    {
                        greater++;
                    }
                    longest = Math.Max(longest, greater);
                }
                
            }
            return longest;
        }
        

        
    }
}
