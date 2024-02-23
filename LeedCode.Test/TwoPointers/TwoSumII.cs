using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int indexLeft = 0;
            int indexRigth = numbers.Length - 1;

            if (numbers.Length > 2)
            {
                while (numbers[indexRigth] > target && indexRigth > 1)
                {
                    indexRigth--;
                }

                while (numbers[indexLeft] + numbers[indexRigth] != target)
                {
                    if (numbers[indexLeft] + numbers[indexRigth] > target)
                    {
                        indexRigth--;
                    }
                    if (numbers[indexLeft] + numbers[indexRigth] < target)
                    {
                        indexLeft++;
                    }
                }
            }

            if (indexLeft > indexRigth)
            {
                return new int[2] { indexRigth + 1, indexLeft + 1 };
            }
            return new int[2] { indexLeft + 1, indexRigth + 1 };

        }
    }
}
