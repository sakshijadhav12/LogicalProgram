using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CuponNumbersProgram
    
        {
            public  void CuponNumbers()
            {
                Console.WriteLine("Enter the number of distinct coupon numbers:");
                int n = int.Parse(Console.ReadLine());

                int totalRandomNumbersNeeded = GenerateDistinctCoupons(n);

                Console.WriteLine($"Total random numbers needed to have all distinct coupons: {totalRandomNumbersNeeded}");
            }

            private static int GenerateRandomCouponNumber(int n)
            {
                Random random = new Random();
                return random.Next(1, n + 1); 
            }

            private static int GenerateDistinctCoupons(int n)
            {
                bool[] collectedCoupons = new bool[n];
                int randomCount = 0;
                int distinctCount = 0;

                while (distinctCount < n)
                {
                    int randomCoupon = GenerateRandomCouponNumber(n);

                    if (!collectedCoupons[randomCoupon - 1])
                    {
                        collectedCoupons[randomCoupon - 1] = true;
                        distinctCount++;
                    }

                    randomCount++;
                }

                return randomCount;
            }
        }
    }

