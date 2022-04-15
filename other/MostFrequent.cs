/*
Given an integer array, find the most frequent number.

E.g.:
Input: [1,5,7,5,2,4,5]
Output: 5

*/
public static partial class Solution{
	public static int MostFrequentWithMap(int[] nums){
		Dictionary<int,int> frequency = new Dictionary<int,int>();
		for(int i=0; i<nums.Length; i++)  {
			if(frequency.ContainsKey(nums[i])){
				int count = frequency[nums[i]];
				frequency[nums[i]] = count+1;
			}else{
				frequency[nums[i]] = 1;
			}
  		}
  		int max = frequency.Max(x=>x.Value);
  		foreach(var pair in frequency){
  			if(pair.Value==max) return pair.Key;
  		}
		  return -1;
	}
	public static int MostFrequentWithSort(int[] nums){
		return -1;
	}
}