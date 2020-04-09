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

        public LinkedList(int [] a)  //
        {
            int[] array = a;
            for (int i = 0; i < array.Length - 1; i++)
            {

                AddAtTheBeggining(a[i]);


            }
           
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
            Node add = new Node(a);
            Node q;
            Node tmp = root;

            if (index != 0)
            {
                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }

                q = tmp.Next;
                tmp.Next = add;
                tmp = tmp.Next;
                tmp.Next = q;
                Lenght++;
            }

            else
            {
                AddAtTheBeggining(a);   //эта часть не работает
            }
        }

        //4
        public void DelTheLastEl()
        {
            Node tmp = root;

            if (Lenght != 1)
            {

                while (tmp.Next.Next != null)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = null;
                Lenght--;
            }

            else
            {
                root = null;
                Lenght--;
            }
        }

        //5 удаление из начала
        public void delTheFirstEl()
        {
            if (Lenght != 1)
            {
                Node tmp = root;
                root = tmp.Next;
            }
            else
            {
                root = null;
            }
            Lenght--;
        }

        //6
        public void delByIndex(int delIndex) //удаление по индексу
        {
            Node tmp = root;

            if (delIndex == 0)
            {
                root = tmp.Next;
            }

            else
            {
                for (int i = 0; i < delIndex - 1; i++)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = tmp.Next.Next;
            }

            Lenght--;
        }

        //7 доступ по индексу
        public int ValueByIndex(int index)
        {
            int value;
            Node tmp = root;

            for (int i = 0; i < index; i++)
            {
                tmp = tmp.Next;
            }
             value=tmp.Value;
                return value;
        }


        //8 индекс по значению
        public int IndexByValue(int a)
        {
            Node tmp = root;
            int Index = -1; //если нет элемента равного а вернет 0

            for (int i = 0; i < Lenght-1; i++)
            {
                if (tmp.Value == a)
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

            if (index != 0)
            {
                int i = 1;

                while (i != index)
                {
                    tmp = tmp.Next;
                    i++;
                }
                tmp.Next.Value = a;
            }

            else
            {
                tmp.Value = a;
            }
        }

        //11 реверс
        public void Reverse() 
        {
            Node tmpRoot = root; //не меняется 
            Node tmp;

            while (tmpRoot.Next != null)
            {
                tmp = tmpRoot.Next;
                tmpRoot.Next = tmpRoot.Next.Next;
                tmp.Next=root;
                root=tmp;
            }

        }

        //12 значение макс эл
        public int MaxElement()
        {
            Node tmp = root;
            int max = tmp.Value;

            for (int i = 1; i <= Lenght; i++)
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
            int Index = 0;

            for (int i = 0; i < Lenght-1; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                    Index = i;
                }
                tmp = tmp.Next;
            }

            return Index;
        }

        public int MinIndex()
        {
            Node tmp = root;
            int min = tmp.Value;
            int Index = 0;

            for (int i = 0; i < Lenght; i++)
            {
                if (min > tmp.Value)
                {
                    min = tmp.Value;
                    Index = i;
                }
                tmp = tmp.Next;
            }

            return Index;
        }
       

        public void SortRise() //???????????????????
        {
            Node prev = null;
            Node minPrev = null;
            Node min = root;
            Node tmp = root;

            while (tmp != null)
            {
                if (min.Value > tmp.Value)
                {
                    min = tmp;
                    minPrev = prev;
                }
                prev = tmp;
                tmp = tmp.Next;
            }
            if (minPrev != null)
            {
                minPrev.Next = minPrev.Next.Next;
                min.Next = root;
                root = min;

            }

            Node plese = root;
            for (int i = 1; i < Lenght ; i++)
            {
                prev = plese;
                minPrev = plese;
                min = plese.Next;
                tmp = plese.Next;
                while (tmp != null)

                {
                    if (min.Value > tmp.Value)
                    {
                        min = tmp;
                        minPrev = prev;

                    }
                    prev = tmp;
                    tmp = tmp.Next;
                }

                minPrev.Next = minPrev.Next.Next;
                min.Next = plese.Next;
                plese.Next = min;
                plese = plese.Next;

            }
        }

        public void SortFall()
        {
            Node prev = null;
            Node maxPrev = null;
            Node max = root;
            Node tmp = root;

            while (tmp != null)
            {
                if (max.Value < tmp.Value)
                {
                    max = tmp;
                    maxPrev = prev;
                }
                prev = tmp;
                tmp = tmp.Next;
            }
            if (maxPrev != null)
            {
                maxPrev.Next = maxPrev.Next.Next;
                max.Next = root;
                root = max;

            }

            Node plese = root;
            for (int i = 1; i < Lenght; i++)
            {
                prev = plese;
                maxPrev = plese;
                max = plese.Next;
                tmp = plese.Next;
                while (tmp != null)

                {
                    if (max.Value < tmp.Value)
                    {
                        max = tmp;
                        maxPrev = prev;

                    }
                    prev = tmp;
                    tmp = tmp.Next;
                }

                maxPrev.Next = maxPrev.Next.Next;
                max.Next = plese.Next;
                plese.Next = max;
                plese = plese.Next;

            }

        }

        //18 удаление по значению
        public void delByValue(int a) 
        {
            Node tmp = root;


            if (root.Value ==a)
            {
                while (tmp.Next.Value ==a)
                {
                    tmp = tmp.Next;
                    Lenght--;
                }
                root = tmp.Next;
                Lenght--;
            }

            while (tmp.Next != null)  
            {
                if (tmp.Next.Value ==a)
                {
                    tmp.Next = tmp.Next.Next;
                    Lenght--;
                }
                else
                {
                    tmp = tmp.Next;
                }
            }
        }

        public int ReturnLenrth()
        {
            
                return Lenght ;
        }

        //добавить массив в конец
        public void AddArrayAtTheEnd(int []a)
        {
            int[] array = a;
            for (int i = 0; i < array.Length ; i++)
            {
                AddAtTheEnd(array[i]);
            }
        }


        public void AddArrayAtTheBeggining(int[] a) //?????????????
        { 
            int[] array = a;
            Node tmp;
            Node q = root;

            for (int i = array.Length-1 ; i >=0; i--)
            {
                 root=   new Node(a[i]);
                tmp = root;
                tmp.Next = q;
                q = root;
            }

            //for (int i=Lenght ; i<1;i++)
            //{
            //    root.Next = new Node(a[i]);
            //    Node tmp = root.Next;
            //    tmp.Next = root.Next.Next;

            //}
            Lenght = Lenght + array.Length;
        }

        public void AddArrayByIndex(int[] a, int index)
        {

            if (index==Lenght)
            {
                AddArrayAtTheEnd(a);
            }

            else if (index==0)
            {
                AddArrayAtTheBeggining(a);
            }

            else
            {
               Node tmp = root;
                Node q;
                for (int i = 0; i<index-1; i++)
                {
                    tmp = tmp.Next;
                }
                q = tmp.Next;

                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }

                tmp.Next = q;

                Lenght = Lenght + a.Length;
            }
        }

        public void DelSeveralLastEl(int a)  
        {
            Node tmp = root;

            for (int i = 1; i < Lenght - a; i++)
            {
                tmp = tmp.Next;
            }

            tmp.Next = null;
            

            Lenght=Lenght -a;

        }

        public void delSeveralFirstEl(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Node tmp = root;
                root = tmp.Next;
            }
                
            Lenght=Lenght -a;

        }

        public void delseveralElByIndex(int a, int delIndex)
        {
            Node tmp = root;

            if (delIndex == 0)
            {

                delSeveralFirstEl(a);
                
            }

            else
            {
                for (int i = 0; i < delIndex - 1; i++)
                {
                    tmp = tmp.Next;
                }

                int j = 0;
                while (j != a)
                {
                    tmp.Next = tmp.Next.Next;
                    j++;
                    Lenght--;
                }
            }
        }

    }
}

