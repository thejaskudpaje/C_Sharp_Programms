using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.Array
{
    [TestClass]
    [TestCategory("Array")]
    public class IntegersComeFirstAndZeroAtLast
    {
        [TestMethod]
        public void execute()
        {
            int[] a = { 2, 0, 8, 0, 9, 0 };

            int[] b = new int[a.Length];
            int m = 0;
            int n = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    b[m] = a[i];
                    m++;
                }
                else
                {
                    b[n] = a[i];
                    n--;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
