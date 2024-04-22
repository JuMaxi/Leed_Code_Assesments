namespace LeedCode.Test.Stack
{
    public class NumberOfStudentsUnableToEatLunchTest
    {
        [Fact]
        public void Test01()
        {
            NumberOfStudentsUnableToEatLunch number = new();

            int[] students = { 1, 1, 0, 0 };
            int[] sandwiches = { 0, 1, 0, 1 };

            int answer = number.CountStudents(students, sandwiches);

            Assert.Equal(0, answer);
        }

        [Fact]
        public void Test02()
        {
            NumberOfStudentsUnableToEatLunch number = new();

            int[] students = { 1, 1, 1, 0, 0, 1};
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };

            int answer = number.CountStudents(students, sandwiches);

            Assert.Equal(3, answer);
        }
    }
}
