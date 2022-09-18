public class Solution {
    public int PivotIndex(int[] nums) {
          var n = nums.Length;
          var forwardSum = new int[n];
            var backwardSum = new int[n];
            
            forwardSum[0] = nums[0];
            backwardSum[n-1] = nums[n-1];
            
            for(int i = 1; i < n; i++)
            {
                forwardSum[i] = forwardSum[i-1] + nums[i];
            }

            for(int i = n-2; i >= 0; i--)
            {
                backwardSum[i] = backwardSum[i+1] + nums[i];
            }
            
            for(int i = 0; i < n; i++)
            {
                if(forwardSum[i] == backwardSum[i])
                {
                    return i;
                }
            }

            return -1;
        }
}