using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.String
{
    [TestClass]
    [TestCategory("String")]
    public class ReverseTheWordinAStringWhichDoesNtContNum
    {
        [TestMethod]
        [TestCategory("String")]
        public void Reverse_Word()
        {
            string s = "price is 50Rs not 30 ";  //ecirp si 50Rs ton 30
            string []ar  = s.Split(' ');
            string output = "";

            for(int i = 0; i < ar.Length; i++)
            {
                string s2 = "";
                char[]ca = ar[i].ToCharArray();
                bool res = Check_char_present(ca);
                if (res == false)
                {
                    int m = 0;
                    int n = ca.Length - 1;
                    while (m < n)
                    {
                        char temp = ca[m];
                        ca[m] = ca[n];
                        ca[n] = temp;
                        m++;
                        n--;
                    }
                   s2 =new string(ca);
                }
                else
                {
                    s2 = new string(ca);

                }
                output = output +" "+ s2;
               
            }
            Console.WriteLine(output);

        }
        public bool Check_char_present(char[]ar)
        {
            bool flag = true;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i]>='0' && ar[i] <= '9')
                {
                    return flag;
                }
            }
            return false;
        }
    }
}
