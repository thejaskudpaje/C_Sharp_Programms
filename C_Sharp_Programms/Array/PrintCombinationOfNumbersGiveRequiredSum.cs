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
    public class PrintCombinationOfNumbersGiveRequiredSum
    {
        [TestMethod]
        public void execute()
        {
            int []a = { 9, 7, 8, 5, 2, 4, 4, 3, 6 };//11

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == 11)
                    {
                        Console.WriteLine(a[i] + "+" + a[j] + "=11");
                        break;//if we have the duplicate values it will give the duplicate result. thats why we should use break here.
                    }
                }
            }
        }
        }
}
