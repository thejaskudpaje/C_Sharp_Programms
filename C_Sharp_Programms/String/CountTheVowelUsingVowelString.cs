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
    public class CountTheVowelUsingVowelString
    {
        [TestMethod]
        public void Vowel_Count_test()
        {
            string s = "MY name is thejas";
           s= s.ToLower();
            Console.WriteLine(s);
            string c = "aeiou";

            for(int i = 0; i < c.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < s.Length; j++)
                {
                    if (c.ElementAt(i) == s.ElementAt(j))
                    {
                        count++;
                    }
                }
                Console.WriteLine(c[i]+"-->"+count);
            }

        }
    }
}
