namespace LeedCode.Test.Recursion
{
    public class PowerOfThreeTest
    {
        [Fact]
        public void Test01()
        {
            PowerOfThree power = new();
            bool answer = power.IsPowerOfThree(27);

            Assert.True(answer);
        }

        [Fact]
        public void Test02()
        {
            PowerOfThree power = new();
            bool answer = power.IsPowerOfThree(0);

            Assert.False(answer);
        }

        [Fact]
        public void Test03()
        {
            PowerOfThree power = new();
            bool answer = power.IsPowerOfThree(-1);

            Assert.False(answer);
        }
    }
}
