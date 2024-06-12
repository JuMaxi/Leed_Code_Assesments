namespace LeedCode.Test.Recursion;

public class PowerOfThree
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        if(n == 1)
        {
            return true;
        }
        else
        {
            bool answer = IsPowerOfThree(n / 3);

            if(n % 3 != 0)
            {
                return false;
            }
            return answer;  
        }

    }
}
