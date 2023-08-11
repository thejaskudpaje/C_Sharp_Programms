using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.PatternProgramms
{
    [TestClass]
    [TestCategory("pattern")]
    public class Pattern01
    {
        /*
         
 *   *   *   *  
 *   *   *   *  
 *   *   *   *  
 *   *   *   *  
 *   *   *   *  
       
         */
        [TestMethod]
        public void execute()
        {
            Console.WriteLine();
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j >= 1; j--)
                {

                    Console.Write(" *  ");
                }
                Console.WriteLine();
            }
        }

    }
}
