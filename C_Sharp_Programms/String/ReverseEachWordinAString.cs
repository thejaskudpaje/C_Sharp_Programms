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
    public class ReverseEachWordinAString
    {
        [TestMethod]
        public void Execute()
        {
            string s = "Im a sdet engineer";
            string[] sa = s.Split(' ');
            for (int i = 0; i < sa.Length; i++)
            {
                string r = sa[i];
                for (int j = r.Length - 1; j >= 0; j--)
                {
                    Console.Write(r.ElementAt(j));
                }
                Console.Write(" ");
            }
        }

        }
    }
