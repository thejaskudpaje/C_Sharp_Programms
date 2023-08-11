using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.NumberSystem
{
    [TestClass]
    [TestCategory("Number system")]
    public class PrimeNumber
    {
        public void Prime_Number_Test()
        {
            //check the number is prime or not
            int n = 10;
            Console.WriteLine("Given number " + n + " is ");
            if (isPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
                Console.WriteLine("Not prime");
            Console.WriteLine("*********************");

            //PrimeNumbers in an Array
            int []s = { 1, 2, 3, 4, 5, 7 };
            Console.WriteLine("prime numbers in the array-->");
            for (int i = 0; i < s.Length; i++)
            {
                if (isPrime(s[i]))
                {
                    Console.Write(s[i] + ", ");
                }

            }
            Console.WriteLine("\n*********************");
            //Prime numbers within limit
            int limit = 20;
            Console.Write("Prime numbers within " + limit + "-->");
            for (int i = 1; i <= limit; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + ", ");
                }
            }

        }
        public static bool isPrime(int n)
        {
            bool flag = true;
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {

                    return false;
                }
            }
            return flag;
        }
    }
}
