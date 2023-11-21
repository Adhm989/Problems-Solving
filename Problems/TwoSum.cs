using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_problems.Problems
{
    public class TwoSum
    {
        public static int[] Claculate(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            int[] res = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
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
    }
}
