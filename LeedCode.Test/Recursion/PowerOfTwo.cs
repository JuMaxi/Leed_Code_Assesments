namespace LeedCode.Test.Recursion
{
    public class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0)
            {
                return false;
            }

            if (n == 1)
            {
                return true;
            }
            else
            {
                bool answer = IsPowerOfTwo(n / 2);

                if(n % 2 != 0)
                {
                    return false;
                }
                return answer;
            }
        }
    }
}
