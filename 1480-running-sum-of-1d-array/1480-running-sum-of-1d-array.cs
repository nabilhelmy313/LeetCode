public class Solution {
    public int[] RunningSum(int[] nums) {
        int len=nums.Length;
        int r=0;
        int[]rSum=new int [len];
        for(int i=0;i<len;i++){
                        
            r+=nums[i];
            rSum[i]=r;
        }
        return rSum;
    }
}