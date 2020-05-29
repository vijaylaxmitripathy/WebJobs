using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace WebJobAzureDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
           // string timer;
            Console.WriteLine("Starting the Web Job Application");

            Stopwatch timer = new Stopwatch();
            timer.Start();

            Console.WriteLine(DateTime.Now);

            for(int i=0;i<15;i++)
            {
                WriteInfo(i);
                Thread.Sleep(500);
            }
            timer.Stop();
            Console.WriteLine("Web Job Procession took:" + timer.Elapsed.Seconds +"seconds");
            Console.WriteLine("Finished the Web Job Application");
        }
        
        static void WriteInfo(int number)
        {
            Console.WriteLine("Working on item:" + number);
        }
    }
}
