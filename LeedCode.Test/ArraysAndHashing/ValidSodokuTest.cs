using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.Test.ArraysAndHashing
{
    public class ValidSodokuTest
    {
        [Fact]
        public void Test01()
        {
            ValidSodoku valid = new();

            char[][] board = new char[][]
            {
                new[]{'5','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','2','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'.','.','.','.','8','.','.','7','9'}
            };

            bool result = valid.IsValidSudoku(board);

            result.Should().BeTrue();
        }

        [Fact]
        public void Test02()
        {
            ValidSodoku valid = new();

            char[][] board = new char[][]
            {
                new[]{'8','3','.','.','7','.','.','.','.'},
                new[]{'6','.','.','1','9','5','.','.','.'},
                new[]{'.','9','8','.','.','.','.','6','.'},
                new[]{'8','.','.','.','6','.','.','.','3'},
                new[]{'4','.','.','8','.','3','.','.','1'},
                new[]{'7','.','.','.','2','.','.','.','6'},
                new[]{'.','6','.','.','.','.','2','8','.'},
                new[]{'.','.','.','4','1','9','.','.','5'},
                new[]{'.','.','.','.','8','.','.','7','9'}
            };

            bool result = valid.IsValidSudoku(board);

            result.Should().BeFalse();
        }
    }
}
