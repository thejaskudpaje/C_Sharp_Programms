using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.Array
{
    [TestCategory("NearestNumber")]
    [TestClass]
    [TestCategory("Array")]
    public class NearestNumber
    {
        [TestMethod]
        public void execute()
        {
            int x = -7;
            int[] a = { -3, -8, -5, -6, 2, -7, -1};
            int res = a[0];
            int gap = x-a[0] ;
            
            if (gap < 0)
            {
                gap = gap * (-1);

            }
           
            for (int i = 1; i < a.Length; i++)
            {
                
                int z = (x - a[i]);
                if (z < 0)
                {
                    z = z * (-1);
                   
                }
                else if (z == 0)
                {
                    Console.WriteLine("same number present");
                    z = gap++;
                   
                }

                if (z < gap)
                {
                     gap = z;
                     res = a[i];
                }
            }
         
            for(int i = 0; i < a.Length; i++)
            {
                int m = a[i] - x;
                if (m < 0)
                {
                    m = m * (-1);
                }
                if (m == gap)
                {
                    Console.WriteLine("Nearest number-->" + a[i]);
                }
            }

        }
    }
}
