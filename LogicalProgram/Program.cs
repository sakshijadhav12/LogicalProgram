using System;

namespace LogicalProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Programs");
        Console.WriteLine("select Option \n1.FibonacciSeries \n2.Perfect Number");
       int options=Convert.ToInt32(Console.ReadLine());
        switch (options)
        {
            case 1:
                FabonacciSeries.SolveFabonacciSeries();
                break;
            case 2:
                PerfectNumber perfectNumber = new PerfectNumber();
                perfectNumber.check();
                break;

        }


        }
}