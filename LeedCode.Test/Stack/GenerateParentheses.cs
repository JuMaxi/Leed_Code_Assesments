namespace LeedCode.Test.Stack
{
    public class GenerateParentheses
    {
        private List<string> result = new List<string>();
        public List<string> GenerateParenthesis(int n) // n = 2
        {
            GenerateCombinations("", n, n);
            return result;
        }

        // "",     2, 2
        // "(",    1, 2
        // "()",   1, 1
        // "()(",  0, 1
        // "()()", 0, 0
        private void GenerateCombinations(string current, int remainingOpen, int remainingClose)
        {
            if (remainingOpen == 0 && remainingClose == 0)
            {
                result.Add(current);
                return;
            }

            bool canOpen  = remainingOpen > 0 && remainingOpen <= remainingClose;
            bool canClose = remainingClose > remainingOpen;

            // Current = "("
            if (canOpen)
                GenerateCombinations(current + "(", remainingOpen - 1, remainingClose); // "(("

            // Current = "("
            if (canClose)
                GenerateCombinations(current + ")", remainingOpen, remainingClose - 1); // "()
        }
    }
}
