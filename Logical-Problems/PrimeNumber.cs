using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    /// <summary>
    /// Prime Number
    /// </summary>
    public class PrimeNumber
    {
        public PrimeNumber()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the Number to check Prime:\n ");
            Console.WriteLine("------------------------------------");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is Not Prime Number.\n");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime Number.\n");
        }
    }
}
