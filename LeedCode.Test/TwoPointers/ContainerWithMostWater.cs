using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int leftIndex = 0;
            int rightIndex = height.Length - 1;
            int area = 0;

            while(leftIndex < rightIndex)
            {
                int actualArea = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);

                area = Math.Max(area, actualArea);

                if (height[leftIndex] < height[rightIndex])
                {
                    leftIndex++;
                }
                else 
                {
                    rightIndex--;
                }
            }

            return area;
        }
    }
}
