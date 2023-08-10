using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumberProgram
    {

            public void CheckPrimeNumber()
            {
                int n, i = 0;
                bool isPrime = true;

                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
       
                for (i = 2; i <= n/2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("Number is Prime.");
                }
                else
                {
                    Console.Write("Number is not Prime.");
                }
            }
        }
       
  }

