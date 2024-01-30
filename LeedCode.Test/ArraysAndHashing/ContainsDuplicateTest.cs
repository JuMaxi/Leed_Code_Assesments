namespace LeedCode.Test.ArraysAndHashing
{
    public class ContainsDuplicateTest
    {
        [Fact]

        public void ContainsDuplicate()
        {
            ContainsDuplicate contaisDuplicate = new();

            bool duplicated = contaisDuplicate.VerifyIfContainsDuplicatedNumberWithDictionary();

            false.CompareTo(duplicated);
        }
    }
}