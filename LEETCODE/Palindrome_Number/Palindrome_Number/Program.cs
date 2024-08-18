using System;
namespace Palindrome_Number
{
    
    class Program
    {
        public bool IsPalindrome(int x) 
    {
        return true;
        
    }
        static void Main(String[] args)
        {
            int num = 1234;
            int x = 0;
            int temp = 0;
            while(num > 0)
            {
                temp = num % 10;
                x = x * 10 + temp;
                num = num / 10;
            }
           System.Console.WriteLine(x);
            
        }
        
    }
}