using System;

namespace LogicalProgram;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Programs");
        Console.WriteLine("select Option \n1.FibonacciSeries");
       int options=Convert.ToInt32(Console.ReadLine());
        switch (options)
        {
            case 1:
                FabonacciSeries.SolveFabonacciSeries();
                break;

        }


        }
}