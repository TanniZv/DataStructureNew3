using System;

namespace DataStructureNew
{
    class Program
    {
       public static void Main(string[] args)
        {
            ArrayList a = new ArrayList();



            a.AddAtTheEnd(8);
            //a.AddAtTheBeggining(40);
            //a.AddAccordingToIndex(33, 1);

            LinkedList L = new LinkedList();
           // L.AddAtTheEnd(1);
           //// qqq(L.ReturnArray());
           // L.AddAtTheEnd(2);
           //// qqq(L.ReturnArray());
           // L.AddAtTheEnd(3);
           // qqq(L.ReturnArray());
            L.AddAtTheBeggining(0);
           
            L.AddAccordingToIndex(2, 56);
             L.AddAtTheEnd(2);
             L.AddAtTheEnd(5);
            //L.DelTheLastEl();
            //L.delTheFirstEl();
            //Console.Write(L.IndexByValue(56
            //L.Reverse();
            //L.delByIndex(2);
            //L.delByValue(56);

            //int[] b = new int[] { 1, 2, 3, 4, 73, 23 };
            //int[] c = new int[] { 100 };
            //L.AddArrayAtTheBeggining(c);
            qqq(L.ReturnArray());
            Console.Write(L.ValueByIndex(2));
        }

        static void qqq(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
    }

