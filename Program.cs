namespace Solving_problems
{
    internal class Program
    {
        public static int[] bubbleSort(int[] a)
        {

            for (int i =0 ; i < a.Length; i++)
            {
                for (int j = 0; j<a.Length-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }

            }
            return a;
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> seen = new Dictionary<int,int>();
            int[] res = new int[2];   

            for(int i = 0; i < nums.Length;i++)
            {
                int diff= target - nums[i];
                if (seen.ContainsKey(diff))
                {
                    res[0] = seen[diff];
                    res[1] = i;
                    break;
                }
                if (!seen.ContainsKey(nums[i]))
                    seen.Add(nums[i], i);
                else
                    continue;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 95, 4, -3 };
            int[] res = bubbleSort(nums);
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }
        }
    }
}