using System;
namespace DataStructureNew
{
    public class L2List : IList
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

        public L2List(int[] a)
        {
            root = null;
            Lenght = 0;
            for (int i = 0; i < a.Length; i++)
            {
                AddAtTheEnd(a[i]);
            }
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

        public void AddAccordingToIndex(int index, int a)  
        {
            if ((index != 0) && (index != Lenght))
            {
                if (index <= Lenght / 2)
                {
                    L2Node tmp = root;
                    L2Node q;

                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }

                    q = tmp.Next;
                    tmp.Next = new L2Node(a);
                    tmp.Next.Next = q;
                    tmp.Next.Previous = tmp;
                    q.Previous = tmp.Next;
                }
                else
                {
                    L2Node tmp = end;                     //эта часть не работает
                    L2Node q;
                    int i = Lenght -1;

                   while (i!=index)
                    {
                        tmp = tmp.Previous ;
                        i--;
                    }

                    q = tmp.Previous ;
                    tmp.Previous  = new L2Node(a);
                    tmp.Previous.Previous  = q;
                    q.Next = tmp.Previous;
                    tmp.Previous.Next = tmp;
                }
                Lenght++;
            }

            else if (index == 0)
            {
                AddAtTheBeggining(a);
            }

            else
            {
                AddAtTheEnd(a);
            }
        }

        public void DelTheLastEl()
        {
            if (Lenght != 1)
            {
                end = end.Previous;
                end.Next = null;
                Lenght--;
            }

            else
            {
                root = null;
                Lenght--;
            }
        }

        public void delTheFirstEl()
        {
            if (Lenght != 1)
            {
                L2Node q;

                q = root.Next;
                root = null;
                root = q;
                Lenght--;
            }

            else
            {
                root = null;
                Lenght--;
            }
        }

        public void delByIndex(int delIndex)
        {

            if ((delIndex != 0) && (delIndex != Lenght - 1))
            {
                L2Node tmp = root;
                for (int i = 0; i < delIndex - 1; i++)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = tmp.Next.Next;
                tmp.Next.Previous = tmp;
                Lenght--;
            }

            else if (delIndex == Lenght - 1)
            {
                DelTheLastEl();
            }

            else
            {
                delTheFirstEl();
            }
        }


        public int ValueByIndex(int index)
        {
            int value;

            if (index <= Lenght / 2)
            {
                L2Node tmp = root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;

                }
                value = tmp.Value;
            }

            else
            {
                L2Node tmp = end;
                int i = Lenght - 1;
                while (i != index)
                {
                    tmp = tmp.Previous;
                    i--;
                }
                value = tmp.Value;

            }

            return value;
        }


        public int IndexByValue(int a)
        {
            L2Node tmp = root;
            int Index = -1; //если нет элемента равного а вернет 0

            for (int i = 0; i < Lenght - 1; i++)
            {
                if (tmp.Value == a)
                {
                    Index = i;
                }

                tmp = tmp.Next;
            }
            return Index;
        }


        public void ChangeByIndex(int index, int a)
        {
            if (index <= Lenght / 2)
            {
                L2Node tmp = root;
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

            else
            {
                L2Node tmp = end;
                if (index != Lenght - 1)
                {
                    int i = Lenght - 2;

                    while (i != index)
                    {
                        tmp = tmp.Previous;
                        i--;
                    }
                    tmp.Previous.Value = a;
                }

                else
                {
                    tmp.Value = a;
                }
            }
        }

        public void Reverse()      
        {
            L2Node tmp = root; 
            L2Node q=null;

            while (tmp != null)
            {
                q = tmp.Previous ;
                tmp.Previous  = tmp.Next ;
                tmp.Next = q;
                tmp = tmp.Previous;
            }
            if (q != null)
            {
                root = q.Previous ;    //если 1 нода
            }
        }


        public int MaxElement()
        {
            L2Node tmp = root;
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


        public int MinElement()
        {
            L2Node tmp = root;
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


        public int MinIndex()
        {
            L2Node tmp1 = root;
            int min1 = tmp1.Value;
            int Index1 = 0;

            L2Node tmp = end;
            int min2 = tmp.Value;
            int Index2 = Lenght - 1;

            for (int j = 0; j <= Lenght / 2; j++)
            {
                if (min1 > tmp1.Value)
                {
                    min1 = tmp1.Value;
                    Index1 = j;
                }
                tmp1 = tmp1.Next;
            }

            for (int j = Lenght - 1; j < Lenght / 2; j--)
            {
                if (min2 > tmp.Value)
                {
                    min2 = tmp.Value;
                    Index2 = j;
                }
                tmp = tmp.Previous;
            }

            if (min1 < min2)
            { return Index1; }
            else { return Index2; }      //ne sravnivaetsya

        }


        public int MaxIndex()
        {
            L2Node tmp = root;
            int max = tmp.Value;
            int Index = 0;

            for (int i = 0; i < Lenght - 1; i++)
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

        public void SortRise() //?????????????
        {
            
        }

        public void SortFall(int[] a)
        { }


        public void delByValue(int a)
        {
            L2Node tmp = root;

            if (root.Value == a)
            {
                while (tmp.Next.Value == a)
                {
                    tmp = tmp.Next;
                    Lenght--;
                }
                root = tmp.Next;
                Lenght--;
            }

            while (tmp.Next != null)
            {
                if (tmp.Next.Value == a)
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
        { return Lenght; }

        public void AddArrayAtTheEnd(int[] a)
        {
            if (a.Length != 0)
            {
                if (Lenght == 0)
                {
                    root = new L2Node(a[0]);
                    end = root;
                    L2Node tmp = root;

                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    end = tmp;
                    Lenght = a.Length;
                }

                else
                {
                    L2Node tmp = root;

                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    Lenght += a.Length;
                }
            }

        }

        public void AddArrayAtTheBeggining(int[] a)
        {
            L2Node tmp;
            L2Node q = root;

            if (Lenght == 0)
            {
                
               //end = new L2Node(a[]);     нужно end присваивать?????????

                for (int i = a.Length - 2; i >= 0; i--)
                {
                    root = new L2Node(a[i]);
                    tmp = root;
                    tmp.Next = q;
                    q = root;
                    
                }
                Lenght = a.Length;
            }

            else
            {
                for (int i = a.Length - 1; i >=0; i--)
                {
                    root.Previous = new L2Node(a[i]);
                    root.Previous.Next = root;
                    root = root.Previous;
                    
                }
             Lenght = Lenght + a.Length;
            }
        }


        public void AddArrayByIndex(int[] a, int index)
        {
            if (index == Lenght)
            {
                AddArrayAtTheEnd(a);
            }

            else if (index == 0)
            {
                AddArrayAtTheBeggining(a);
            }

            else
            {
                if (index <= Lenght / 2)
                {
                    L2Node tmp = root;
                    L2Node q;
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    q = tmp.Next;

                    for (int i = 0; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp = tmp.Next;
                    }

                    tmp.Next = q;
                }

                else
                {

                    L2Node tmp =end ;                //эта часть не работает
                    L2Node q;
                    int i = Lenght - 1;
                    while (i != index)
                    {
                        tmp = tmp.Previous ;
                        i--;
                    }
                    q = tmp.Previous ;

                    for (int j=a.Length-1; j>=0 ; j--)
                    {
                        tmp.Previous  = new L2Node(a[i]);
                        tmp = tmp.Previous ;
                    }

                    tmp.Previous = q;
                }

                Lenght = Lenght + a.Length;
            }
        }

        public void DelSeveralLastEl(int a)
        {
            L2Node tmp = end;
            int i = 1;
            while (i!=a+1)
            {
                tmp = tmp.Previous;
                i++;
            }
            tmp.Next = null;
            end = tmp;
            Lenght = Lenght - a;
        }

        public void delSeveralFirstEl(int a)
        {
            L2Node tmp = root;
            int i = 1;
            while (i != a + 1)
            {
                tmp = tmp.Next ;
                i++;
            }
            tmp.Previous  = null;
            root = tmp;
            Lenght = Lenght - a;
        }


        public void delseveralElByIndex(int a, int delIndex)
        {
            if (delIndex == 0)
            {
                delSeveralFirstEl(a);
            }

            else if (delIndex == Lenght - 1)
            {
                DelSeveralLastEl(1);
            }

            else
            {
                L2Node tmp = root;
                int j = 0;

                for (int i = 0; i < delIndex - 1; i++)
                {
                    tmp = tmp.Next;
                }

                while (j != a)
                {
                    if (tmp.Next.Next  == null)
                    {
                        end = tmp;

                    }

                    else
                    {
                        tmp.Next = tmp.Next.Next;     //как сделать чтобы правильно проходил тест если удаляются элементы до конца
                        tmp.Next.Previous = tmp;
                        Lenght--;
                    }
                    
                    j++;

                    
                }

            }

        }
           
    }
}

