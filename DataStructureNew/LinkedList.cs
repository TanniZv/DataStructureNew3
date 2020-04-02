﻿using System;
namespace DataStructureNew
{
    public class LinkedList//: IList 
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
        public void DelTheLastEl() //не работает
        {
            Node tmp = root;

           while (tmp.Next.Next!=null)
            {
                tmp = tmp.Next;
            }

            tmp.Next  = null;
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

            for (int i=1; i<delIndex-2; i++)
            {
                tmp = tmp.Next;
            }

            tmp.Next  = tmp.Next.Next ;

            Lenght--;
        }

        ////7 доступ по индексу
        //public int ValueByIndex(int index)
        //{
        //    return;
        //}


        //8 индекс по значению
        public int IndexByValue(int a)
        {
            Node tmp = root;
            int Index=-1; //если нет элемента равного а вернет 0

            for (int i = 1; i < Lenght ; i++)
            {
                if (tmp.Value ==a)
                {
                    Index = i;
                }

                tmp = tmp.Next;
            }
            return Index;

        }

        //9 изменение по индексу
        public void ChangeByIndex(int index, int a)
        {
            Node tmp = root;
            int i = 1;

            while ( i!= index)
            {
                tmp = tmp.Next;
                i++;
            }

            tmp.Next.Value = a;
        }

        //11 реверс
        public void Reverse()
        {
            Node tmpRoot = root;
            Node tmp;

            for (int i=1; i<=Lenght; i++)
            {
                tmpRoot.Next = root;
                tmp = root; 
            }

        }

        //12 значение макс эл
        public int MaxElement()
        {
            Node tmp = root;
            int max=tmp.Value;

            for (int i=1; i<=Lenght; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                }
                tmp = tmp.Next;
            }

            return max;
        }

        // 13 значение мин
        public int MinElement()
        {
            Node tmp = root;
            int min = tmp.Value;

            for (int i = 1; i <= Lenght; i++)
            {
                if (min > tmp.Value)
                {
                    min = tmp.Value;
                }
                tmp = tmp.Next;
            }

            return min;
        }

        // 15 поиск макс индекс
        public int MaxIndex()
        {
            Node tmp = root;
            int max = tmp.Value;
            int Index=1;

            for (int i = 1; i <= Lenght; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                    Index = i;
                }
                tmp = tmp.Next;
            }

            return Index ;
        }



    }
}

