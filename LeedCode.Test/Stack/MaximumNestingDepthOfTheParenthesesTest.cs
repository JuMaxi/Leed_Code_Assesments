namespace LeedCode.Test.Stack
{
    public class MaximumNestingDepthOfTheParenthesesTest
    {
        [Fact]
        public void Test01()
        {
            MaximumNestingDepthOfTheParentheses maximum = new();

            string s = "(1+(2*3)+((8)/4))+1";

            int answer = maximum.MaxDepth(s);

            Assert.Equal(3, answer);
        }

        [Fact]
        public void Test02()
        {
            MaximumNestingDepthOfTheParentheses maximum = new();

            string s = "(1)+((2))+(((3)))";

            int answer = maximum.MaxDepth(s);

            Assert.Equal(3, answer);
        }
    }
}
