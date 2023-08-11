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
    public class AdditionOfAnArray
    {
        [TestMethod]
        public void execute()
        {
            int[] a = { 4, 2, 5, 1 };
            int[] b = { 3, 1, 6, 4, 3 };
            int len;

            if (a.Length > b.Length)
            {
                len = a.Length;
            }
            else if (a.Length < b.Length)
            {
                len = b.Length;
            }
            else
                len = a.Length;
            //System.out.println(len);

            int[] c = new int[len];
            for (int i = 0; i < len; i++)
            {
                try
                {
                    c[i] = a[i] + b[i];
                }
                catch (Exception e)
                {
                    if (a.Length > b.Length)
                    {
                        c[i] = a[i];
                    }
                    if (a.Length < b.Length)
                    {
                        c[i] = b[i];
                    }
                }

            }
            Console.WriteLine("Addition of two arrays");
            for (int i = 0; i < len; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
