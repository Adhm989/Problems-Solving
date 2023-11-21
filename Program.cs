using Solving_problems.Problems;

namespace Solving_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int res = SearchInSortedRotatedArray.SearchInRotatedArray(nums , 10);
            Console.WriteLine(res);
        }
    }
}