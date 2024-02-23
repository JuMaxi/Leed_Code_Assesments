using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class ValidSodoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool rows = CheckRow(board);
            bool columns = CheckColumn(board);
            bool square = CheckSquare(board);

            if (rows && columns && square)
            {
                return true;
            }
            return false;
        }

        private bool IsValidUnit(char[] unit)
        {
            HashSet<char> chars = new HashSet<char>();

            foreach (char c in unit)
            {
                if (c != '.')
                {
                    if (chars.Contains(c))
                    {
                        return false;
                    }
                    chars.Add(c);
                }
            }
            return true;
        }

        private bool CheckRow(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                if (!IsValidUnit(board[row]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool CheckColumn(char[][] board)
        {
            char[] columns = new char[board.Length];
            int column = 0;

            while (column < board.Length)
            {
                for (int row = 0; row < board.Length; row++)
                {
                    columns[row] = board[row][column];
                }

                if (!IsValidUnit(columns))
                {
                    return false;
                }
                column++;
            }
            return true;
        }
        private bool CheckSquare(char[][] board)
        {
            for (int i = 0; i < board.Length; i += 3)
            {
                for (int j = 0; j < board.Length; j += 3)
                {
                    char[] square = new char[board.Length];
                    int index = 0;

                    for (int row = i; row < i + 3; row++)
                    {
                        for (int column = j; column < j + 3; column++)
                        {
                            square[index++] = board[row][column];
                        }
                    }

                    if (!IsValidUnit(square))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Better solution to study
        //public bool IsValidSudoku(char[][] board)
        //{
        //    HashSet<string> seen = new HashSet<string>();
        //    for (int i = 0; i < 9; ++i)
        //    {
        //        for (int j = 0; j < 9; ++j)
        //        {
        //            if (board[i][j] != '.')
        //            {
        //                string b = "(" + board[i][j] + ")";
        //                if (!seen.Add(b + i) || !seen.Add(j + b) || !seen.Add(i / 3 + b + j / 3))
        //                    return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

    }
}
