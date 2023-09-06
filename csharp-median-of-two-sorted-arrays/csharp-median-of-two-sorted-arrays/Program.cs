using csharp_median_of_two_sorted_arrays;

internal class Program
{ 
    private static void Main(string[] args)
    {
        int[] nums1 = new int[] { 1, 3 };
        int[] nums2 = new int[] { 2, 7 };
        Console.WriteLine(Solution.FindMedianSortedArrays(nums1, nums2));
    }
}