using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveStaircase
{
    public class RecursiveStaircaseSolution
    {
        public static int Solve(int n, int[] jumps)
        {
            if (jumps.Length == 0) return 1;

            if (HasDuplicates(jumps)) throw new Exception("Jumps list cannot contain duplicates"); 

            int[] solvedCache = new int[n + 1];
            solvedCache[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int total = 0;

                for (int j = 0; j < jumps.Length; j++)
                {
                    int jumpBy = jumps[j];

                    if (jumpBy > i) continue;

                    total += solvedCache[i - jumpBy];
                }

                solvedCache[i] = total;
            }

            int result = solvedCache[n];
            return result;
        }

        private static bool HasDuplicates(int[] nums)
        {
            var result = nums.GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() });
            foreach (var item in result)
            {
                if (item.val > 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
