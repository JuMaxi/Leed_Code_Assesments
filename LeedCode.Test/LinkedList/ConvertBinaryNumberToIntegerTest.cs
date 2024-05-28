namespace LeedCode.Test.LinkedList
{
    public class ConvertBinaryNumberToIntegerTest
    {
        [Fact]
        public void Test01()
        {
            Node head = new();
            head.Data = 1;
            head.Add(0);
            head.Add(1);

            ConvertBinaryNumberToInteger convert = new();

            int answer = convert.GetDecimalValue(head);

            Assert.Equal(5, answer);
        }

        [Fact]
        public void Test02()
        {
            Node head = new();
            head.Data = 0;

            ConvertBinaryNumberToInteger convert = new();

            int answer = convert.GetDecimalValue(head);

            Assert.Equal(0, answer);
        }
    }
}
