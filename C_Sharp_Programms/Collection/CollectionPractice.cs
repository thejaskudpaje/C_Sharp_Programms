using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ThejasProject01.Collection
{
    [TestClass]
    [TestCategory("Collections")]
    public class CollectionPractice
    {
        [TestMethod]
        public void List()
        {
            //List
            //declaring initializing seperately
            List<string> names = new List<string>();
            names.Add("virat");
            names.Add("rohit");
            Console.WriteLine("Output of List");
            Console.WriteLine(names[0]);  //virat

            //declaration and initialization at same time
            List<string> name = new List<string> { "hardhik", "krunal" };//hardhik
            Console.WriteLine(name[0]);
        }

        [TestMethod]
        public void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(5);
            arrayList.Add(3);
            foreach(int i in arrayList)
            {
                Console.Write(i+" ");  //1  5  3
            }
            Console.WriteLine();


            //inserting one more element
            arrayList.Insert(1, 10);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");  //1  10  5  3
            }
            Console.WriteLine();

            //Removing elements using two methods
            arrayList.Remove(10);
            arrayList.RemoveAt (0);


            // arrayList.RemoveAt(ind);
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");  //  5  3
            }

        }

        [TestMethod]
        public void hashset() { 


        //HashSet
        HashSet<int> hs =new HashSet<int>();   
            hs.Add(15);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            hs.Add(30);
            hs.Add(10);
            Console.WriteLine("\nOutput of HashSet");
            //Printing using for each loop
            foreach (int i in hs)
            {
                Console.Write(i+" "); //15 10 20 30
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void SortedSet() {
            //SortedSet
            SortedSet<char> ss = new SortedSet<char>();
            ss.Add('m');
            ss.Add('n');
            ss.Add('a');
            ss.Add('i');
            ss.Add('m');
            ss.Add('c');
            Console.WriteLine("\nOutput of SortedSet");
            //Printing using for each loop
            foreach (char i in ss)
            {
                Console.Write(i + " "); //a c i m n
            }
            Console.WriteLine();
        }

        [TestMethod]
        public void Stack() {
            //Stack
            Stack<string> st = new Stack<string>();
            st.Push("Banana");
            st.Push("Apple");
            st.Push("Banana");
            st.Push("Orange");
            st.Push("jackfruite");
            //printing as LIFO order
            foreach (string i in st)
            {
                Console.Write(i + " "); //jackfruite Orange Banana Apple Banana
            }

            //Printing and deleting last in element
            Console.WriteLine("\n" + st.Pop());

            //printing after pop
            foreach (string i in st)
            {
                Console.Write(i + " "); // Orange Banana Apple Banana
            }

            string a = st.Peek();
            Console.WriteLine(a);//Orange
        }

        [TestMethod]
        public void Queue() {

            //Queue
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            //Printing as FIFO order
            foreach (int i in q)
            {
                Console.Write(i + " "); // 10 20 30 40
            }
            Console.WriteLine();
            //removing first element and printing
            q.Dequeue();
            foreach (int i in q)
            {
                Console.Write(i + " "); //  20 30 40
            }
            Console.WriteLine();

        }

        [TestMethod]
        public void LinkedList() {

            //LinkedList
            LinkedList<char> ll = new LinkedList<char>();
            ll.AddFirst('a');
            ll.AddFirst('b');
            ll.AddLast('c');
            ll.AddLast('d');
            foreach (char i in ll)
            {
                Console.Write(i + " "); //b a c d
            }
            Console.WriteLine();
            LinkedListNode<char> node = ll.Find('a');
            ll.AddAfter(node, 'x');
            ll.AddBefore(node, 'y');
            foreach (char i in ll)
            {
                Console.Write(i + " "); //b y a x c d
            }

            Console.WriteLine();
          

        }

        [TestMethod]

        public void Dictionary() {
            //Dictionary
            Dictionary<int, String> d = new Dictionary<int, String>();
            d.Add(1, "bangalore");
            d.Add(2, "chennai");
            d.Add(3, "mumbai");
            d.Add(4, "kolkatta");

            foreach (var i in d)
            {
                Console.Write(i + " "); // [1, bangalore] [2, chennai] [3, mumbai] [4, kolkatta]
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, String> i in d)
            {
                Console.Write(i.Key + ":" + i.Value + "  ");//1:bangalore  2:chennai  3:mumbai  4:kolkatta
            }
            Console.WriteLine();

        }

        [TestMethod]
        public void SortedDictionary() {
            //SortedDictionary
            var sd = new SortedDictionary<int, String>();
            sd.Add(1, "idli");
            sd.Add(5, "vada");
            sd.Add(3, "dosa");
            sd.Add(2, "puliyogare");
            //sorting and printing based on the value
            foreach (var i in sd)
            {
                Console.Write(i + " "); //[1, idli] [2, puliyogare] [3, dosa] [5, vada]
            }

        }

        [TestMethod]
        public void SortedList() { 
        //SortedList
        SortedList<int, String> sl =new SortedList<int, String>();
            sl.Add(1, "alpha");
            sl.Add(3, "beta");
            sl.Add(2, "gama");
            foreach (var i in sl)
            {
                Console.Write(i + " "); //[1, alpha] [2, gama] [3, beta]
            }
        }
    }
}
