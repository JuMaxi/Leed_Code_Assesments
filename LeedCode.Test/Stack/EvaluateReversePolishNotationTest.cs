namespace LeedCode.Test.Stack
{
    public class EvaluateReversePolishNotationTest
    {
        [Fact]
        public void Test01()
        {
            EvaluateReversePolishNotation evaluate = new();
            string[] tokens = { "2", "1", "+", "3", "*" };

            int answer = evaluate.EvalRPN(tokens);

            Assert.Equal(9, answer);
        }

        [Fact]
        public void Test02()
        {
            EvaluateReversePolishNotation evaluate = new();
            string[] tokens = { "4", "13", "5", "/", "+" };

            int answer = evaluate.EvalRPN(tokens);

            Assert.Equal(6, answer);
        }

        [Fact]
        public void Test03()
        {
            EvaluateReversePolishNotation evaluate = new();
            string[] tokens = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };

            int answer = evaluate.EvalRPN(tokens);

            Assert.Equal(22, answer);

        }

    }
}
