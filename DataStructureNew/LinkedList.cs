using System;
namespace DataStructureNew
{
    public class LinkedList: IList 
    {
        
            private Node root;

            public int Lenght { get; private set; }

            public LinkedList()
            {
                root = null;
                Lenght = 0;
            }

            public LinkedList(int a)
            {
                root = new Node(a);
                Lenght = 1;
            }

            public void AddAtTheEnd(int a)
            {
                if (Lenght == 0)//(root==null)
                {
                    root = new Node(a);
                    Lenght = 1;
                }
                else if (Lenght == 1)//(root!=null&&root.Next==null)
                {
                    root.Next = new Node(a);
                    Lenght++;
                }
                else
                {
                    Node tmp = root;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = new Node(a);
                    Lenght++;
                }
            }

            public int[] ReturnArray()
            {
                int[] array = new int[Lenght];
                if (Lenght != 0)
                {
                    int i = 0;
                    Node tmp = root;
                    do
                    {
                        array[i] = tmp.Value;
                        i++;
                        tmp = tmp.Next;
                    } while (tmp != null);
                }
                return array;
            }

            public void AddAtTheBeggining(int a)
            {
                Node tmp = new Node(a);
                tmp.Next = root;
                root = tmp;
                Lenght++;
            }

        //3
        public void AddAccordingToIndex(int index, int a)
        {
            Node add = new Node (a);
            Node q;
            Node tmp = root;

            for (int i=0; i<index-2; i++)
            {
                tmp=tmp.Next;
            }

            q=tmp.Next;
            tmp.Next=add ;
            tmp = tmp.Next;
            tmp.Next = q;
            Lenght++;
        }

        //4
        public void DelTheLastEl()
        {
            Node tmp = root;

           while (tmp.Next!=null)
            {
                tmp = tmp.Next;
            }

            tmp = null;
            Lenght--;
        }

        //5 удаление из начала
        public void delTheFirstEl()
        {
            Node tmp = root;
            root = tmp.Next;
            Lenght--;
        }

        //6
        public void delByIndex(int delIndex) //удаление по индексу
        {
            Node tmp = root;
            Node q;

            for (int i=1; i<=delIndex; i++)
            {
                tmp = tmp.Next;
            }

            for (int i= delIndex; i<=Lenght;i++ )
            {

            }
            Lenght--;
        }

        ////7 доступ по индексу
        //public int ValueByIndex(int index)
        //{
        //    return;
        //}





        }
}

