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
    public class FirstThreeMinNumberOfAnArray
    {
        [TestMethod]
        
        public void execute()
        {
            int[] a = { 2, 8, 6, 9, 1, 7 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("First minimum-->" + a[0]);
            Console.WriteLine("Second minimum-->" + a[1]);
            Console.WriteLine("Third minimum-->" + a[2]);
        }
    }
}
