using System;
namespace DataStructureNew
{
    public class L2List
    {
        private L2Node root;
        private L2Node end;
        public int Lenght { get; private set; }

        public L2List()
        {
            root = null;
            end = null;
            Lenght = 0;
        }

        public L2List(int a)
        {
            root = new L2Node(a);
            end = root;
            Lenght = 1;
        }

        public L2List (int [] a)
        {

        }

        public int[] ReturnArray()
        {
            int[] array = new int[Lenght];
            if (Lenght != 0)
            {
                int i = 0;
                L2Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void AddAtTheEnd(int a)
        {
            if (Lenght == 0)
            {
                root = new L2Node(a);
                end = root;
                Lenght = 1;
            }
            else
            {
                end.Next = new L2Node(a);
                end.Next.Previous = end;
                end = end.Next;
                Lenght++;
            }
        }

        public void AddAtTheBeggining(int a)
        {
            if (Lenght == 0)
            {
                root = new L2Node(a);
                end = root;
                Lenght = 1;
            }
            else
            {
                root.Previous = new L2Node(a);
                root.Previous.Next = root;
                root = root.Previous;
                Lenght++;
            }
        }

        //public int[] ReturnArray()
        //{
        //    int[] array = new int[Lenght];
        //    if (Lenght != 0)
        //    {
        //        int i = 0;
        //        L2Node tmp = root;
        //        do
        //        {
        //            array[i] = tmp.Value;
        //            i++;
        //            tmp = tmp.Next;
        //        } while (tmp != null);
        //    }
        //    return array;
        //}
    }
}
