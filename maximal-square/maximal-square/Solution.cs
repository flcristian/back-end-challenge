namespace maximal_square;

public class Solution
{
    private bool IsSquare(char[][] matrix, int startI, int startJ, int length)
    {
        if (startI + length > matrix.Length) return false;
        for (int i = startI + 1; i < startI + length; i++)
        {
            for (int j = startJ; j < startJ + length; j++)
            {
                if (matrix[i][j] == '0') return false;
            }
        }
        return true;
    }
    
    public int MaximalSquare(char[][] matrix)
    {
        int maxLength = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            int length = 0;
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == '1')
                {
                    if (IsSquare(matrix, i, j - length, length + 1))
                    {
                        length++;
                        maxLength = Math.Max(maxLength, length);
                    }
                    else
                    {
                        length--;
                        j--;
                    }
                }
                else length = 0;
            }
        }
        return (int)Math.Pow(maxLength, 2);
    }
}