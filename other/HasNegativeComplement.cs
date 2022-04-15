/*
Given an integer array, find all positive numbers that have negative complements.

E.g.: 
Input: [1,3,7,-3,-1] 
Output: [1,3]

*/
public static partial class Solution{
	public static int[] HasNegativeWithSet(int[] nums){
		HashSet<int> negatives= new HashSet<int>();
		List<int> results = new List<int>();
		for(int i=0; i<nums.Length; i++){
			if(nums[i]<0) negatives.Add(nums[i]); 
		}
		for(int i=0; i<nums.Length; i++){
			if(nums[i]>0 && negatives.Contains(-1*nums[i])) results.Add(nums[i]);
		}
		return results.ToArray();
	}
	public static int[] HasNegativeWithSort(int[] nums){
		return null;
	}
}