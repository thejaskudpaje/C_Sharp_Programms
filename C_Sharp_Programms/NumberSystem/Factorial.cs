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
    public class Factorial
    {
        [TestMethod]
        public void Factorial_Test()
        {
            int n = 3;

            Console.WriteLine(fact(n));

        }
        public static int fact(int n)
        {
            int prod = 1;
            while (n > 1)
            {
                prod = prod * n;
                n--;
            }
            return prod;
        }
    }
}
