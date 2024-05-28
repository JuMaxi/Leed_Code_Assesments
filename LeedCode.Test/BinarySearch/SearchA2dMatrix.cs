namespace LeedCode.Test.BinarySearch
{
    public class SearchA2dMatrix
    {
        //This is not finished.
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int initialRow = 0;
            int endRow = matrix.Length-1;

            int initialColumn = 0;
            int endColumn = matrix[0].Length-1;

            int middleRow = 0;
            int middleColumn = 0;

            //Find the row;
            while (initialRow <= endRow)
            {
                middleRow = (initialRow + endRow) / 2;

                if(target > matrix[middleRow][initialColumn])
                {
                    initialRow = middleRow + 1;
                }
                else
                {
                    if(target < matrix[middleRow][initialColumn])
                    {
                        endRow = middleRow - 1;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            //Find the column;
            while(initialColumn <= endColumn)
            {
                middleColumn = (initialColumn + endColumn) / 2;

                if(target > matrix[middleRow][middleColumn])
                {
                    initialColumn = middleColumn + 1;
                }
                else
                {
                    if(target < matrix[middleRow][middleColumn])
                    {
                        endColumn = middleColumn - 1;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
