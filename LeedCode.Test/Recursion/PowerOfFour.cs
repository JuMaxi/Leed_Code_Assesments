namespace LeedCode.Test.Recursion;

public class PowerOfFour
{
    public bool IsPowerOfFour(int n)
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
            bool answer = IsPowerOfFour(n / 4);

            if (n % 4 != 0)
            {
                return false;
            }
            return answer;
        }
    }


}
