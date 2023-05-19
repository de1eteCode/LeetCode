using System.Collections;

namespace TwoSum;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var currentIndex = 0;

        while (currentIndex < nums.Length - 1) {
            for (var i = currentIndex + 1; i < nums.Length; i++) {
                if (nums[currentIndex] + nums[i] == target) {
                    return new [] { currentIndex, i };
                }
            }

            currentIndex++;
        }

        return new []{ -1, -1};
    }
    
    public int[] TwoSum_ByHashTable(int[] nums, int target) {
        var hash = new Hashtable();

        for (int i = 0; i < nums.Length; i++) {
            var x = target - nums[i];

            if (hash.Contains(x)) {
                return new[] { (int)hash[x]!, i };
            }

            hash[nums[i]] = i;
        }

        return new[] { -1, -1 };
    }
}