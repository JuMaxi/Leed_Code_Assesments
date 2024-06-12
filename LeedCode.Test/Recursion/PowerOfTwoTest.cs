namespace LeedCode.Test.Recursion
{
    public class PowerOfTwoTest
    {
        [Fact]
        public void Test01()
        {
            PowerOfTwo power = new();
            bool answer = power.IsPowerOfTwo(1);

            Assert.True(answer);
        }

        [Fact]
        public void Test02()
        {
            PowerOfTwo power = new();
            bool answer = power.IsPowerOfTwo(16);

            Assert.True(answer);
        }

        [Fact]
        public void Test03()
        {
            PowerOfTwo power = new();
            bool answer = power.IsPowerOfTwo(3);

            Assert.False(answer);
        }

    }
}
