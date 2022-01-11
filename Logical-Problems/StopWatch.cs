using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
 public class StopWatch
    {
        public  StopWatch()
        {

            //// start holds the stating time and stop holding ending time
            ///
            Console.WriteLine("Present Time :" + DateTime.Now.ToString("HH:mm:ss tt"));
            Console.WriteLine("----------------------------------");
            int start, stop;
            start = DateTime.Now.Second;
            Console.WriteLine("Timer started: please press enter to stop ");
            Console.ReadLine();
            stop = DateTime.Now.Second;
            Console.WriteLine("Elapsed time in seconds {0} ", stop - start);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("After Elapsed "+ DateTime.Now.ToString("HH:mm:ss tt"));
        }
    }
}

        

