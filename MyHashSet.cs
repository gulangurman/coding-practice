/*
705. Design HashSet

Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
 
Example 1:

Input
["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
[[], [1], [2], [1], [3], [2], [2], [2], [2]]
Output
[null, null, null, true, false, null, true, null, false]

Explanation
MyHashSet myHashSet = new MyHashSet();
myHashSet.add(1);      // set = [1]
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(1); // return True
myHashSet.contains(3); // return False, (not found)
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(2); // return True
myHashSet.remove(2);   // set = [1]
myHashSet.contains(2); // return False, (already removed)
 
Constraints:

0 <= key <= 106
At most 104 calls will be made to add, remove, and contains.

*/
/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
public class MyHashSet {
    private List<int>[] buckets;
    private static int NUM_BUCKETS = 10000;
  
   private int Hash(int key){
     return key % NUM_BUCKETS;
   }

    public MyHashSet() {
      buckets = new List<int>[NUM_BUCKETS];
      for(int i=0;i<NUM_BUCKETS;i++){
        buckets[i] = new List<int>();
      }
    }
    
    public void Add(int key) {
      int hash = Hash(key);
      var bucket = buckets[hash];
      if(bucket != null && bucket.Count()>0){ // collision
        if(!bucket.Contains(key)){
          bucket.Add(key);
        }
      }else{        
        bucket.Add(key);
      }      
    }
    
    public void Remove(int key) {
          int hash = Hash(key);
       var bucket = buckets[hash];
      if(bucket.Contains(key)){
        bucket.Remove(key);
      }
    }
    
    public bool Contains(int key) {
         int hash = Hash(key);
       var bucket = buckets[hash];
      return bucket.Contains(key);
    }
}