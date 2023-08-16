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
    public class RemoveDuplicatesinAString
    {
        [TestMethod]
        public void RemoveDuplicateTest()
        {
            string s = "aabccbbdddeeee"; //abcde
          s=  s.ToLower();
            int[] ar = new int[26]; 
            for(int i = 0; i < s.Length; i++)
            {
                char c=s.ElementAt(i);
                ar=Count(ar, c);
            }

            for(int j = 0; j < ar.Length; j++)
            {
                if (ar[j] == 1)
                {
                    Console.WriteLine((char)(j+97));
                }
            }
        }
        public static int[] Count(int[] ar, char c)
        {
            int ascii = c - 97;
            int value = ar[ascii];
            if (value == 0)
            {
                value++;
                ar[ascii] = value;
            }
            return ar;
        }
    }
}
