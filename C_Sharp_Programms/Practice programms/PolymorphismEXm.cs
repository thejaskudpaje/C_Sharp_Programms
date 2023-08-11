using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programms.Practice_programms
{
    public class PolymorphismEXm
    {
    }
   /*     public interface IThejas
        {
            const int a = 10;
            static int b = 20;
            public void Neil();
            public abstract void Abhi();
            public abstract void Jerry();
        }

        public abstract class Datta : IThejas
    {

            string book = "Abstract book";
            public static void print()
            {
                Console.WriteLine(IThejas.a);
                Console.WriteLine(IThejas.b);

            }
            public Datta()
            {

                Console.WriteLine("Constructor of datta");
            }

            public void Neil()
            {
                Console.WriteLine("datta calling neil");
            }

            public virtual void Abhi()
            {
                Console.WriteLine("datta calling abhi");
            }

            public abstract void Jerry();

        }

        public class Veena : Datta
        {
            public override sealed void Abhi()
            {
                Console.WriteLine("veena callig abhi");
            }

            public override sealed void Jerry()
            {
                Console.WriteLine("Veena calling jerry ");
            }

        }

        public abstract class Varun : IThejas
    {
            public Varun(int m) : this()
            {
                Console.WriteLine("One argument constructor Of Varun");
            }
            public Varun()
            {
                Console.WriteLine("No argument constructor Of Varun");
            }
            public void Neil()
            {
                Console.WriteLine("Varun calling neil");
            }

            public void Abhi()
            {
                Console.WriteLine("Varun calling Abhi");
            }

            public abstract void Jerry();


        }

        public class Yesu : Varun
        {
            public Yesu(int m) : base(m)
            {
                Console.WriteLine("One argument constructor Of Yesu");
            }
            public Yesu() : this(10)
            {
                Console.WriteLine("No argument constructor Of Yesu");
            }
            public override sealed void Jerry()
            {
                Console.WriteLine("yesu Calling Jerry");
            }
        }

        public class Sushma
        {
            public static void Excecute()
            {
                //Creating the upcasted object for abstract class Datta
                Datta ob1 = new Veena();
                Yesu ob2 = new Yesu();

            IThejas ob3 = new Veena();
                ob3.Neil();
                ob3.Abhi();
                ob3.Jerry();

                Datta ob4 = new Veena();
                ob4.Abhi();
                ob4.Jerry();
                Console.WriteLine("value of a is-->" + IThejas.a);
                Console.WriteLine("value of b is-->" + IThejas.b);



            }
        }*/
    }


