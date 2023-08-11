using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.Array
{
    [TestClass]
    [TestCategory("Array")]
    public class FirstAndSecondMaxNumberWithoutBBLSort
    {

        [TestMethod]
        public void execute()
        {
            int[] a = { 1, 1, 1, 2, 8, 14, 1 };
            int fmax = a[0];
            int smax = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= fmax)
                {
                    if (a[i] > fmax)
                    {
                        smax = fmax;
                    }
                    fmax = a[i];
                }
                else if (fmax == smax || smax < a[i])
                {
                    smax = a[i];
                }

            }

            Console.WriteLine(fmax);
            Console.WriteLine(smax);
        }
    }
}
