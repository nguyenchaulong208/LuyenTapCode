using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm1
{
    public class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        return arr;
                        break;
                    }
                }
            }
            return null;
        }
    
  
            
        static void Main(string[] args)
        {
        /*
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
           You may assume that each input would have exactly one solution, and you may not use the same element twice.
           can return the answer in any order.
         */
        int[] arrNums = {2, 5, 5, 11};
        int targetArr = 10;
        int[] result = new int[2];

            result= Algorithm1.Program.TwoSum(arrNums, targetArr);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
