using trapping_rain_water;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] height = { 4,2,0,3,2,5 };

        Solution sol = new Solution();
        Console.WriteLine(sol.Trap(height));
    }
}