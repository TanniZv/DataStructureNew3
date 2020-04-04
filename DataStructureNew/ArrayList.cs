using System;

namespace DataStructureNew
{
    
        public class ArrayList : IList
        {
            private int[] array;
            private int length;

            public int this[int a]
            {
                get { return array[a]; }
                set { array[a] = value; }
            }

        //public ArrayList()
        //{
        //    array = new int[0];
        //    length = 0;

        //}

        //public void AddMass(int[] array)
        //{
        //    int[] Array = new int[length ];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Array[i] = array[i];
        //    }
        //}

        public int[] ReturnArray()
            {
                int[] arrayToReturn = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arrayToReturn[i] = array[i];
                }

                return arrayToReturn;
            }


            public ArrayList()
            {
                array = new int[0];
                length = 0;
            }

            public ArrayList(int a)
            {
                array = new int[1] { a };
                length = 1;
            }

            public ArrayList(int[] a)
            {
                array = a;
                length = a.Length;
            }

            private void UpArraySize()
            {
                int newL = Convert.ToInt32(array.Length * 1.3 + 1);
                int[] newArray = new int[newL];

                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }



            //1
            public void AddAtTheEnd(int a) //расширение массива
            {
                if (length >= array.Length)
                {
                    UpArraySize();
                }


                array[length] = a; //добавление нового элемента
                length++;
            }

            //2
            public void AddAtTheBeggining(int a)
            {
                if (length >= array.Length)
                {
                    UpArraySize();
                }

                for (int i = length ; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }


                array[0] = a;
                length++;
            }


            //3
            public void AddAccordingToIndex(int index, int a)
            {

                if (length >= array.Length)
                {
                    UpArraySize();
                }

                for (int i = length ; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = a;
                length++;
            }

            //4
            public void DelTheLastEl()
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
                length--;
            }

            //5 удаление из начала
            public void delTheFirstEl()
            {
                int[] newArray = new int[array.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + 1];
                }
                array = newArray;
                length--;
            }


            //6
            public void delByIndex(int delIndex) //удаление по индексу
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < delIndex; i++)
                {
                    newArray[i] = array[i];
                }
                for (int i = delIndex; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + 1];
                }
                array = newArray;
                length--;
            }

            //7 доступ по индексу
            public int ValueByIndex(int index)
            {
                int i = 0;
                while (i != index)
                {
                    i++;
                }

                return array[i];
            }

            //8 индекс по значению
            public int IndexByValue(int a)
            {
                int index = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == a)
                    {
                        index = i;
                        break;
                    }

                    else { index = -1; }
                }
                return index;

            }

            //9 изменение по индексу
            public void ChangeByIndex(int index, int a)
            {
                array[index] = a;
            }


            //11 реверс
            public void Reverse()
            {
                int q = 0;

                if (length % 2 == 0)
                {
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        q = array[i];
                        array[i] = array[length - 1 - i];
                        array[length - 1 - i] = q;
                    }
                }

                else
                {
                    for (int i = 0; i < (length - 1) / 2; i++)
                    {
                        q = array[i];
                        array[i] = array[length - 1 - i];
                        array[length - 1 - i] = q;
                    }
                }
            }


            //12 значение макс эл

            public int MaxElement()
            {
                 int[] a = array;

                int max = a[0];

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                return max;
            }


            // 13 значение мин
            public int MinElement()
            {
            int[] a = array;
            int min = a[0];

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
                return min;
            }

            // 15 поиск мin индекс
            public int MinIndex()
            {
                int[] newArray = array;
                int min = newArray[0];
                int minIndex = 0;

                for (int i = 0; i <newArray.Length; i++)
                {
                    if (newArray [i] < min)
                    {
                        min = newArray [i];
                        minIndex = i;
                    }
                }
                return minIndex;
            }

            // 14 поиск мax индекс
            public int MaxIndex()
            {
            int[] a = array;
                int max = a[0];
                int maxIndex = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }


            //16 сортировка по возрастанию
            public void SortRise()
            {
            int[] a = array;
            int q;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            q = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = q;
                        }
                    }
                }

            }

            //17 сортировка по убыванию
            public void SortFall(int[] a)
            {
                int q;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j] < a[j + 1])
                        {
                            q = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = q;
                        }
                    }
                }

            }

            //18 удаление по значению
            public void delByValue(int a) 
            {
                int k = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == a)
                    {
                        k = k + 1;
                    }
                }

                int[] newArray = new int[array.Length - k];
                int kol = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != a)
                    {
                        for (int j = kol; j < newArray.Length; j++)
                        { newArray[j] = array[i]; }
                        kol += 1;

                    }

                }
                array = newArray;
                length = length - k;
            }

            //19 вернуть длину
            public int ReturnLenrth()
            {

                return length;

            }

            //21 добавление массива в конец
            public void AddArrayAtTheEnd(int[] a)
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }

                for (int i = 0; i < a.Length; i++)
                {
                    array[length + i] = a[i];
                }

                length += a.Length;
            }

            //22 добавление массива в начало
            public void AddArrayAtTheBeggining(int[] a)
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }

                int[] newArray = new int[length + a.Length];

                for (int i = a.Length; i < length + a.Length; i++)
                {
                    newArray[i] = array[i - a.Length];
                }

                for (int i = 0; i < a.Length; i++)
                {
                    newArray[i] = a[i];
                }

                array = newArray;
                length += a.Length;
            }

            //23 добавление массива по индексу
            public void AddArrayByIndex(int[] a, int index)
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }

                int[] newArray = new int[length + a.Length];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }

                for (int i = index; i < index + a.Length; i++)
                {
                    newArray[i] = a[i - index];
                }

                for (int i = a.Length + index; i < length + a.Length; i++)
                {
                    for (int j = index; j < array.Length; j++)
                    {
                        newArray[i] = array[j];
                        index++;
                        break;
                    }
                }
                array = newArray;
                length += a.Length;
            }

            //24 удаление из конца N элементов
            public void DelSeveralLastEl(int a)
            {
                int[] newArray = new int[array.Length - a];

                for (int i = 0; i < array.Length - a; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
                length -= a;
            }

            //25 удаление из начала N элементов
            public void delSeveralFirstEl(int a)
            {
                int[] newArray = new int[array.Length - a];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + a];
                }
                array = newArray;
                length -= a;
            }

            //26 удаление по индексу N элементов
            public void delseveralElByIndex(int a, int delIndex)
            {
                int[] newArray = new int[array.Length - a];

                for (int i = 0; i < delIndex; i++)
                {
                    newArray[i] = array[i];
                }
                for (int i = delIndex; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + a];
                }
                array = newArray;
                length -= a;
            }

        }
    }
