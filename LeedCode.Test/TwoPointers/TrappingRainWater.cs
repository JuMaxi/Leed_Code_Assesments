using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.TwoPointers
{
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = left + 1;
            int area = 0;

            if (height.Length < 3) { return 0; }

            while (right < height.Length - 1)
            {
                while (height[left] > height[right])
                {
                    right++;

                    if (right == height.Length - 1)
                    {
                        if (height[right] < height[right - 1])
                        {
                            right--;
                        }
                        break;
                    }
                }

                int smallerHeight = Math.Min(height[left], height[right]);

                int sum = height.Skip(left + 1).Take(right - (left + 1)).Sum();

                area += (smallerHeight * (right - left - 1)) - sum;

                left = right;
                right = left + 1;
            }

            if(area < 0) { area *= -1; }
            return area;
        }
    }
}
