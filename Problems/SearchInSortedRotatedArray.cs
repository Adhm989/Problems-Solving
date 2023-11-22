using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_problems.Problems
{
    public class SearchInSortedRotatedArray
    {
        public static int SearchInRotatedArray(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = (start + end) / 2;
            int res = binarysearch(start, mid, end, nums, target);
            return res;
        }
        public static int binarysearch(int start, int mid, int end, int[] nums, int target)
        {
            if (nums[mid] == target)
                return mid;
            if (mid == start && mid == end && nums[mid] != target)
                return -1;
            if (nums[mid] >= nums[start])
            {
                if (nums[mid] < target || nums[start] > target)
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                    return binarysearch(start, mid, end, nums, target);
                }
                else
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                    return binarysearch(start, mid, end, nums, target);
                }
            }
            else
            {
                if (target < nums[mid] || target > nums[end])
                {
                    end = mid - 1;
                    mid = (start + end) / 2;
                    return binarysearch(start, mid, end, nums, target);
                }
                else
                {
                    start = mid + 1;
                    mid = (start + end) / 2;
                    return binarysearch(start, mid, end, nums, target);
                }
            }
            return -1;

        }
    }
}
