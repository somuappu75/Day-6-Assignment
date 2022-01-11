using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
  public  class PerfectNumber
    {
        /// <summary>
        /// Perfect Number
        /// </summary>
        public  PerfectNumber()
        { 
        int number, sum = 0, n;
            ///enter a Number 
        Console.Write("Enter the Number:\n");
            Console.WriteLine("-----------------------------------------------");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i<number;i++)
            {
                if (number % i == 0)
                {
                    sum=sum + i;
                }
                }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                
            }
}
}
}
