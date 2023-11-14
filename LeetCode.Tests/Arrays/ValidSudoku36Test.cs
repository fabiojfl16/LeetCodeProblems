using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class ValidSudoku36Test
{
    [Fact]
    public void ShouldBeValidSudoku()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var sudoku = new ValidSudoku36();
        bool isValid = sudoku.IsValidSudoku(board);

        // Assert
        Assert.True(isValid);
    }

    [Fact]
    public void ShouldBeInvalidSudoku()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        // Act
        var sudoku = new ValidSudoku36();
        bool isValid = sudoku.IsValidSudoku(board);

        // Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ShouldBeInvalidWithDuplicatedColumnValue()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] { '.', '.', '4', '.', '.', '.', '6', '3', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '5', '.', '.', '.', '.', '.', '.', '9', '.' },
            new char[] { '.', '.', '.', '5', '6', '.', '.', '.', '.' },
            new char[] { '4', '.', '3', '.', '.', '.', '.', '.', '1' },
            new char[] { '.', '.', '.', '7', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
        };

        // Act
        var sudoku = new ValidSudoku36();
        bool isValid = sudoku.IsValidSudoku(board);

        // Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ShouldReturnFalseWhen3x3HasNoValue()
    {
        // Arrange
        char[][] board = new char[][]
        {
            new char[] {'.', '.', '.', '.', '5', '.', '.', '1', '.'},
            new char[] {'.', '4', '.', '3', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '3', '.', '.', '1'},
            new char[] {'8', '.', '.', '.', '.', '.', '.', '2', '.'},
            new char[] {'.', '.', '2', '.', '7', '.', '.', '.', '.'},
            new char[] {'.', '1', '5', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '2', '.', '.', '.'},
            new char[] {'.', '2', '.', '9', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '4', '.', '.', '.', '.', '.', '.'}
        };

        // Act
        var sudoku = new ValidSudoku36();
        bool isValid = sudoku.IsValidSudoku(board);

        // Assert
        Assert.False(isValid);
    }
}