using System;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n----Logical Pgrogramming Practices----");
                    Console.WriteLine("\n1.Fibonacci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse Number \n5.Coupon Number\n6.Stopwatch\n7.Exit\n");
                    Console.WriteLine("\nEnter Your Option:");
                    int option = Convert.ToInt32(Console.ReadLine());       // converting string value to int

                    switch (option)
                    {
                        case 1:
                            FibonacciSeries  fibonacci= new FibonacciSeries();
                            break;

                        case 2:
                            PerfectNumber perfect = new PerfectNumber();
                            break;

                        case 3:
                            PrimeNumber prime = new PrimeNumber();
                            break;

                        case 4:
                            ReverseNumber reverse= new ReverseNumber();
                           break;
                        case 5:
                            CalcCoupon coupon = new CalcCoupon();
                            break;
                        case 6:
                            StopWatch watch = new StopWatch();
                            break;

                        case 7:
                            flag = false;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter valid Input");
              
            }

            Console.ReadKey();
        }
    }
}
