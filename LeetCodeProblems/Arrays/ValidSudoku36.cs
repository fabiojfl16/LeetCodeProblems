namespace LeetCode.Arrays;

public class ValidSudoku36
{
    public bool IsValidSudoku(char[][] board)
    {
        var rowMap = new Dictionary<int, HashSet<int>>();
        var columnMap = new Dictionary<int, HashSet<int>>();

        for (int rowIndex = 0; rowIndex < board.Length; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < board.Length; columnIndex++)
            {
                if (board[rowIndex][columnIndex] == '.')
                    continue;

                int value = int.Parse(board[rowIndex][columnIndex].ToString());

                if (!rowMap.ContainsKey(rowIndex))
                    rowMap[rowIndex] = new HashSet<int>();
                else if (rowMap[rowIndex].Contains(value))
                    return false;

                rowMap[rowIndex].Add(value);

                if (!columnMap.ContainsKey(columnIndex))
                    columnMap[columnIndex] = new HashSet<int>();
                else if (columnMap[columnIndex].Contains(value))
                    return false;

                columnMap[columnIndex].Add(value);
            }
        }

        return true;
    }
}