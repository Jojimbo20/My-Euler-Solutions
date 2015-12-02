using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace Euler_4
{
    class Program
    {
        static bool isPalindrome(int x)
        {            
            //I declared two strings, one to store the unchanged number
            //One to store the reversed number
            string unReversed = x.ToString();
            string Reversed = Hello.Reverse(unReversed);

            //Because I can't figure out how to compare strings I'm gonna compare the ints
            int reversedInt = Convert.ToInt32(Reversed);
              
            //If the reversed one and the normal one are th e same it's a palindrome
               if(x == reversedInt)
                  {
                    return (true);
                  }

            else
            return (false);
        }
        static void Main(string[] args)
        {
            int product = 0;
            int palindrome = 0;
            //Make a looper that multiplies one 3 digit number by another  
            for(int a = 1000; a > 100; --a)
            {
                for(int b = 1000; b > 100; --b)
                {
                    product = a * b;

                    if (isPalindrome(product))
                    {
                        if( palindrome < product)
                        {
                            palindrome = product;
                        }
                        Console.WriteLine("palindrome: {0}", palindrome);
                        
                    }
              
                    
                }
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }
}
