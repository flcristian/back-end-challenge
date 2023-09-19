public class Solution
{
    public bool BinarySearch(int[][] x, int s, int d, int n)
    {
        int m = (s + d) / 2;
        if (s > d)
        {
            return false;
        }
        if (x[m / x[0].Length][m % x[0].Length] == n)
        {
            return true;
        }
        else
        {
            if (n < x[m / x[0].Length][m % x[0].Length])
            {
                return BinarySearch(x, s, m - 1, n);
            }
            else
            {
                return BinarySearch(x, m + 1, d, n);
            }
        }
    }

    public bool SearchMatrix(int[][] matrix, int target)
    {
        return BinarySearch(matrix, 0, matrix.Length * matrix[0].Length - 1, target);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 3, 5, 7 };
        matrix[1] = new int[] { 10, 11, 16, 20 };
        matrix[2] = new int[] { 23, 30, 34, 60 };

        for (int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }

        Solution sol = new Solution();
        Console.WriteLine(sol.SearchMatrix(matrix, 2));
    }
}