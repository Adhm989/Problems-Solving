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
        public static int SearchInRotatedArray(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length-1;
            int mid = (start + end) / 2;
            int res = binarysearch(start, mid, end, nums, target);
            return res;
        }
        public static int binarysearch(int start , int mid , int end , int[] nums , int target)
        {
            if (nums[mid] == target)
                return mid;
            if (nums[mid] >= nums[start])
            {
                if (nums[mid] < target || nums[start]> target) 
                {
                    start = mid + 1; 
                    mid = (start + end) / 2;   
                    return binarysearch(start, mid , end , nums , target);
                }
                else
                {
                    end = mid - 1; 
                    mid = (start +end) / 2;
                    return binarysearch(start, mid , end , nums , target);
                }
            }
            else
            {
                if(target < nums[mid] || target > nums[end])
                {
                    end = mid - 1; 
                    mid = (start +end) / 2;
                    return binarysearch(start, mid , end , nums , target);
                }
                else
                {
                    start = mid + 1; 
                    mid = (start +end) / 2;
                    return binarysearch(start, mid , end , nums , target);
                }
            }
            return -1;

        }


        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int res = SearchInRotatedArray(nums , 10);
            Console.WriteLine(res);
        }
    }
}