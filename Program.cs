using Solving_problems.Problems;

namespace Solving_problems
{
    internal class Program
    {
        //public static int smallestNumber(int[] nums)
        //{
        //    for (int i =0; i<1000000; i++) { 

        //    }
        //}
        static void Main(string[] args)
        {
            int[] A = { 0 ,4,1,0,3 };
            int[] B = { 0, -2, 5, 0, 3 };  
            //int res = SearchInSortedRotatedArray.SearchInRotatedArray(nums , 3);

            int sum1 = 0; 
            int sum2 = 0;
            int tmp1 = A[0];
            int tmp2 = B[0];
            int count = 0;

            for (int i =0; i < A.Length; i++)
            {
                sum1 += A[i];
                sum2 += B[i];
            }

            for (int i = 1; i < A.Length; i++)
            {
                if (i != 1 && tmp1 == tmp2 && (2 * tmp1) == sum1 && (2 * tmp2) == sum2)
                {
                    count++;
                }
                tmp1+= A[i];
                tmp2+= B[i];
            }
            Console.WriteLine(count);
        }
    }
}