namespace Medium;

public class Arrays
{
    #region 931. Minimum Falling Path Sum
    /// <summary>
    /// Calculates the minimum falling path sum in the given matrix.
    /// </summary>
    /// <param name="matrix">The input matrix.</param>
    /// <returns>The minimum falling path sum.</returns>
    /// <time>Runtime: O(m * n)</time>
    /// <space>Memory: O(1)</space>
    public int MinFallingPathSum(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int row = 1; row < rows; row++)
            for (int col = 0; col < cols; col++)
                matrix[row][col] += Math.Min(matrix[row - 1][col], Math.Min(matrix[row - 1][Math.Max(0, col - 1)], matrix[row - 1][Math.Min(cols - 1, col + 1)]));

        return matrix[rows - 1].Min();
    }

    // detailed code
    //public int MinFallingPathSum(int[][] matrix)
    //{
    //    // Get the number of rows and columns in the matrix.
    //    int rows = matrix.Length;
    //    int cols = matrix[0].Length;

    //    // Iterate through the matrix starting from the second row.
    //    for (int r = 1; r < rows; r++)
    //    {
    //        for (int c = 0; c < cols; c++)
    //        {
    //            // Calculate the values from the upper row (left, middle, right).
    //            int left = (c > 0) ? matrix[r - 1][c - 1] : int.MaxValue;
    //            int middle = matrix[r - 1][c];
    //            int right = (c < cols - 1) ? matrix[r - 1][c + 1] : int.MaxValue;

    //            // Update the current element with the minimum sum.
    //            matrix[r][c] += Math.Min(left, Math.Min(middle, right));
    //        }
    //    }

    //    // Return the minimum sum from the last row.
    //    return matrix[rows - 1].Min();
    //}
    #endregion
}
