namespace LeedCode.Test.BinarySearch
{
    public class SearchIntegerTest
    {
        [Fact]
        public void Test01()
        {
            SearchInteger search = new();
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;

            int answer = search.Search(nums, target);

            Assert.Equal(4, answer);
        }

        [Fact]
        public void Test02()
        {
            SearchInteger search = new();
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 2;

            int answer = search.Search(nums, target);

            Assert.Equal(-1, answer);
        }

        [Fact]
        public void Test03() 
        {
            SearchInteger search = new();
            int[] nums = { 5 };
            int target = 5;

            int answer = search.Search(nums, target);

            Assert.Equal(0, answer);
        }
    }
}
