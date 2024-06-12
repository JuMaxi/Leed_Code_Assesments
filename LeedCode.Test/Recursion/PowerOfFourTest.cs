namespace LeedCode.Test.Recursion
{
    public class PowerOfFourTest
    {
        [Fact]
        public void Test01()
        {
            PowerOfFour power = new();
            bool answer = power.IsPowerOfFour(16);

            Assert.True(answer);
        }

        [Fact]
        public void Test02()
        {
            PowerOfFour power = new();
            bool answer = power.IsPowerOfFour(5);

            Assert.False(answer);
        }

        [Fact]
        public void Test03()
        {
            PowerOfFour power = new();
            bool answer = power.IsPowerOfFour(1);

            Assert.True(answer);
        }

        [Fact]
        public void Test04()
        {
            PowerOfFour power = new();
            bool answer = power.IsPowerOfFour(-2147483648);

            Assert.False(answer);
        }

        [Fact]
        public void Test05()
        {
            PowerOfFour power = new();
            bool answer = power.IsPowerOfFour(0);

            Assert.False(answer);
        }
    }
}
