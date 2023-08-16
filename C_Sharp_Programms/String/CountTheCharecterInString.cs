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
    public class CountTheCharecterInString
    {
        [TestMethod]
        public void Count_Character()
        {
            string s = "Im Working in Test yantra";
        
            s=s.ToLower();

            int[] ar = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
               
                ar =  Count(ar, c);
            }

            for(int j = 0; j < ar.Length; j++)
            {
               if (ar[j] != 0) {
                    Console.WriteLine($"{(char)(j + 65)}-->{ar[j]}");
                }
            }
        }

        public  int[] Count(int[]ar, char ch)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                int ascii = ch - 97;
                int value = ar[ascii];
                value++;
                ar[ascii] = value;
            }
            return ar;

        }
    }
}
