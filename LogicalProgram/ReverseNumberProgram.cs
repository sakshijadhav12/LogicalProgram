using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumberProgram
       {
        public void ReverseNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10; 
                reverse = reverse * 10 + remainder; 
                number = number / 10; 
            }

            Console.WriteLine($"Reversed number: {reverse}");
        }
    }

}

