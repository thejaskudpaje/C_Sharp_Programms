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
    public class CharecterPositionFromLast
    {
        [TestMethod]
        public void Charecter_Position_From_Last()
        {
            string s = "kannada";
            List<Char> lhs = new List<Char>();
            for (int i = 0; i < s.Length; i++)
            {
                lhs.Add(s.ElementAt(i));
            }


            foreach (Char c in lhs)
            {
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    if (c == s.ElementAt(j))
                    {
                        Console.WriteLine(c + " is in " + (j + 1) + " position");
                        break;
                    }
                }
            }
        }
    }
}
