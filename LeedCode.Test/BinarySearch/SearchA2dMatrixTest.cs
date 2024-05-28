namespace LeedCode.Test.BinarySearch
{
    public class SearchA2dMatrixTest
    {
        [Fact]
        public void Test01()
        {
            SearchA2dMatrix search = new();
            int[][] matrix = [[ 1, 3, 5, 7 ], [10, 11, 16, 20], [23, 30, 34, 60]];
            int target = 3;

            bool answer = search.SearchMatrix(matrix, target);

            Assert.True(answer);
        }

        [Fact]
        public void Test02()
        {
            SearchA2dMatrix search = new();
            int[][] matrix = { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] };
            int target = 13;

            bool answer = search.SearchMatrix(matrix, target);

            Assert.False(answer);
        }
    }
}
