using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatchptrogram
  
    {
        public void StopWatch()
        {
 
            Console.WriteLine("Press Enter to start the stopwatch...");
            Console.ReadLine(); 

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press Enter to stop the stopwatch...");
            Console.ReadLine();

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine($"Elapsed time: {elapsedTime.TotalSeconds} seconds");
        }
    }

}

