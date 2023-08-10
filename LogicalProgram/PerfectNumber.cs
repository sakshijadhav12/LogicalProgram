using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void check()
        {
            Console.WriteLine("please enter number to check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPerfectNumber(num))
            {
                Console.WriteLine($"{num} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Perfect Number.");
            }
        }
        static bool IsPerfectNumber(int num)
        {
            int sumOfDivisors = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            return sumOfDivisors == num;
        }

    }
}

    

