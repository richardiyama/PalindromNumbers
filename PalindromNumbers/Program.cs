using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumbers
{
    class Program
    {
        static int IsPalindrome_solution(int number)
        {
            int reversed = 0;
            int copy = number;
            while (number != 0)
            {
                reversed = reversed * 10 + (number % 10);
                number = number / 10;
            }
            return (reversed == copy) ? 1 : 0;
        }
        static void Main(string[] args)
        {
           
           
               
            System.Console.Write("Enter '1' to start the program: ");
            string lineStart = Console.ReadLine();

           
          


            int startExecution = int.Parse(lineStart);
           

           
            if (startExecution == 1)
            {

                while (startExecution != -1)
                {
                    System.Console.Write("Enter a number whose digit is more than one or more and i will tell if it's a Palindrome Number: ");

                    string line = Console.ReadLine();
                    int number = int.Parse(line);
               
                    int checkPalindrome = IsPalindrome_solution(number);
               
                    if (checkPalindrome != 0)
                    {
                        System.Console.WriteLine("This is a Palindrome Number");
                    }

                    else
                    {
                        System.Console.WriteLine("This is not a Palindrome Number");
                    }

                }
            }
            else
            {
                System.Console.WriteLine("You entered a wrong number,therefore the program will not start,Please run the program again and enter '1'");
            }
                  
        }
    }
}
