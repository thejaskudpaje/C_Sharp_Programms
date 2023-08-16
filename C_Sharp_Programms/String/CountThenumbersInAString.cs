using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.String
{
    [TestClass]
    [TestCategory("String")]
    public class CountThenumbersInAString
    {
        [TestMethod]
        public void CountNumbers()
        {
            int sum = 0;
            int tsum = 0;
            string s = "1lack50thousand500";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                  
                    sum = sum*10 + 48-s[i];
                }
                else
                {
                    tsum = tsum + sum;
                    sum = 0;
                }
            }

            tsum = tsum + sum;
            Console.WriteLine("Sum is-->"+tsum);
        }
    }
}
