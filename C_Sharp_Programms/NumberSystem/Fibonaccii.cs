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
    public class Fibonaccii
    {
        public void Fibonaccii_Test()
        {
            int limit = 100;
            int f1 = 0;
            int f2 = 1;

            int f3 = f1 + f2;
            while (f1 < limit)
            {
                Console.WriteLine(f1 + "  ");
                f1 = f2;
                f2 = f3;
                f3 = f1 + f3;
            }
        }
    }
}
