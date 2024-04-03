namespace LeedCode.Test.Stack
{
    public class RemoveAllAdjacentDuplicatesInStringTest
    {
        [Fact]
        public void Test01()
        {
            RemoveAllAdjacentDuplicatesInString remove = new();

            string answer = remove.RemoveDuplicates("abbaca");

            string expected = "ca";

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test02()
        {
            RemoveAllAdjacentDuplicatesInString remove = new();

            string answer = remove.RemoveDuplicates("azxxzy");

            string expected = "ay";

            Assert.Equal(expected, answer);
        }
    }
}
