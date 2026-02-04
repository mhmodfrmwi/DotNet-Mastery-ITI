using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        #region https://leetcode.com/problems/contains-duplicate/description/
        public bool ContainsDuplicate(int[] nums)
         {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            
            {
                if (dic.ContainsKey(nums[i])) { 
                    return true;
                }
                dic.Add(nums[i],1);
            }
            return false;
         }
        #endregion
        static void Main(string[] args)
        {
            
        }
        
    }
}
