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
    public class FirstThreeMinNumbersWithoutUsingBBLSort
    {

        [TestMethod]
        public void execute()
        {
            int[] a = { 1, 3, 2, 8, 2, 14, 1 };
            int fmin = a[0];
            int smin = a[0];
            int tmin = a[0];

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] <= fmin)
                {
                    if (a[i] != fmin)
                    {
                        tmin = smin;
                        smin = fmin;
                    }
                    fmin = a[i];
                }
                else if (fmin == smin || a[i] <= smin)
                {
                    if (a[i] < smin)
                    {
                        tmin = smin;
                    }
                    smin = a[i];
                }
                else if (tmin == smin || fmin == tmin || a[i] <= tmin)
                {
                    tmin = a[i];
                }
            }
            Console.WriteLine(fmin + "\n" + smin + "\n" + tmin);
        }
    }
}
