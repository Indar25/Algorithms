namespace DSA_Sorting;
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 108, 19, 35, 21, 77, 59, 77, 47, 209, 99, 3, 7 };
        ArrayProblems ob = new ArrayProblems();
        int start = 0, end = arr.Length - 1;
        ob.MergeSort(start, end, arr);
        Console.WriteLine(string.Join(",", arr));

        Console.WriteLine("Hello, World!");
    }
}
