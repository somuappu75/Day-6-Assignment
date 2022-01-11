using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    class ReverseNumber
    {
        public ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter A Number To Check Reverse: ");
            Console.WriteLine("-----------------------------------------------");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number Is: " + reverse);
        }
        
    }
}
