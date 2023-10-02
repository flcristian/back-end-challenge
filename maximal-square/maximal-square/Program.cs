using maximal_square;

internal class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        char[][] matrix = new char[9][];
        matrix[0] = new[] { '0','0','1','1','0','0','1','0','1','1','1' };
        matrix[1] = new[] { '0','1','1','1','1','1','1','1','1','1','0' };
        matrix[2] = new[] { '0','1','1','1','1','1','1','1','1','1','1' };
        matrix[3] = new[] { '0','1','1','1','1','1','1','1','1','1','1' };
        matrix[4] = new[] { '0','1','1','1','1','1','1','1','1','1','0' };
        matrix[5] = new[] { '0','1','1','1','1','1','1','1','1','1','0' };
        matrix[6] = new[] { '0','1','1','1','1','1','1','1','1','1','0' };
        matrix[7] = new[] { '0','1','1','1','1','1','1','1','1','1','1' };
        matrix[8] = new[] { '0','0','1','1','1','1','1','1','1','1','1' };
        Console.WriteLine(sol.MaximalSquare(matrix));
    }
}