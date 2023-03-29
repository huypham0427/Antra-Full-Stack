// LeetCode Questions Numbers to do: 1, 9, 217, 412

using System;
class LeetCode {
  static void Main() {
    Console.WriteLine("LeetCode-1");
  }
  // Question 1
  public int[] TwoSum(int[] nums, int target) {
        
        if(nums == null || nums.Length < 2)
            return new int[2];
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i]))
                return new int[]{i, dic[target - nums[i]]};
            else if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }
        
        return new int[2];
  }

  // Question 9
 public bool IsPalindrome(int x) {
        int rev = 0, temp = x;
        while(temp > 0){
            rev = rev*10 + temp%10;
            temp /= 10;
        }
        return x == rev;
        
  }
  // Question 217
  public bool ContainsDuplicate(int[] nums) {
        var hash=new HashSet<int>();
        foreach (var item in nums)
            if (!hash.Add(item)) return true;
        return false;
  }
  // Question 412
    public IList<string> FizzBuzz(int n) {
        List<string> result = new List<string>(n);
        for(int i=1,fizz=0,buzz=0; i<=n; i++){
            fizz++;
            buzz++;
            if(fizz == 3 && buzz == 5){
                result.Add("FizzBuzz");
                fizz = 0;
                buzz = 0;
            }else if(fizz == 3){
                result.Add("Fizz");
                fizz = 0;
            }else if(buzz == 5){
                result.Add("Buzz");
                buzz = 0;
            }else{
                result.Add(i.ToString());
            }
        } 
        return result;
    }
}