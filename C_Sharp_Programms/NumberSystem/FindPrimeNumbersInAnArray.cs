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
    public class FindPrimeNumbersInAnArray
    {
        public void Find_Prime_Numbers_InAnArray()
        {
            int []s = { 1, 2, 3, 4, 5, 7 };
            Console.WriteLine("prime numbers in the array");
            for (int i = 0; i < s.Length; i++)
            {
                if (isPrime(s[i]))
                {
                    Console.WriteLine(s[i] + ", ");
                }

            }

        }
        public static bool isPrime(int n)
        {
            bool flag = true;
            if (n == 1)
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
