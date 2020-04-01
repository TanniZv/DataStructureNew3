using NUnit.Framework;
using DataStructureNew;

namespace Tests
{
   
        public class ListTest
        {
            IList actual;
            int q;

        [SetUp]
        public void ListSelect()
        {
            switch (q)
            {
                case 1:
                    actual = new ArrayList();
                    break;

                case 2:
                    actual = new LinkedList();
                    break;
            }
        }

            [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 4, 1, 2, 3 })]
            [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
            public int[] AddAtTheBegginingTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddAtTheBeggining(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 7, ExpectedResult = new int[] { 1, 2, 3, 7 })]
            public int[] AddAtTheEndTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddAtTheEnd(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
            public int[] AddArrayAtTheEndTest(int[] array, int[] a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddArrayAtTheEnd(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 1, 2, 3 })]
            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 9, ExpectedResult = new int[] { 1, 2, 3, 9, 4, 5 })]
            public int[] AddAccordingToIndexTest(int[] array, int index, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddAccordingToIndex(index, a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2 })]
            public int[] DelTheLastElTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.DelTheLastEl();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 2, 3 })]
            [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
            public int[] delTheFirstElTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.delTheFirstEl();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 2, 3 })]
            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, 4, ExpectedResult = new int[] { 1, 2, 3, 54, 23 })]
            public int[] delByIndexTest(int[] array, int index)
            {
                ArrayList actual = new ArrayList(array);
                actual.delByIndex(index);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 4, 73, 23 }, 4, ExpectedResult = 73)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 5, ExpectedResult = 23)]
            public int ValueByIndexTest(int[] array, int index)
            {
                ArrayList actual = new ArrayList(array);
                actual.ValueByIndex(index);
                return actual.ValueByIndex(index);
            }

            [TestCase(new int[] { 1, 2, 3, 4, 73, 23 }, 4, ExpectedResult = 3)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 4, ExpectedResult = -1)]
            public int IndexByValuexTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.IndexByValue(a);
                return actual.IndexByValue(a);
            }


            [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 2, 3 })]
            public int[] ChangeByIndexTest(int[] array, int index, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual[index] = a;
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 7, 6, 5, 4, 3 }, ExpectedResult = new int[] { 3, 4, 5, 6, 7 })]
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] ReverseTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.Reverse();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 73)]
            [TestCase(new int[] { 7 }, ExpectedResult = 7)]
            public int MaxElementTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.MaxElement(array);
                return actual.MaxElement(array);
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 1)]
            [TestCase(new int[] { 1, 2, 3, -54, 73, 23 }, ExpectedResult = -54)]
            [TestCase(new int[] { 7 }, ExpectedResult = 7)]
            public int MinElementTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.MinElement(array);
                return actual.MinElement(array);
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 4)]
            [TestCase(new int[] { 7 }, ExpectedResult = 0)]
            public int MaxIndexTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.MaxIndex(array);
                return actual.MaxIndex(array);
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 0)]
            [TestCase(new int[] { 7 }, ExpectedResult = 0)]
            public int MinIndexTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.MinIndex(array);
                return actual.MinIndex(array);
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3 })]
            [TestCase(new int[] { 7, 6, 5, 4, 3 }, ExpectedResult = new int[] { 3, 4, 5, 6, 7 })]
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] SorRiseTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.SorRise(array);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 7, 6, 1, 4, 3 }, ExpectedResult = new int[] { 7, 6, 4, 3, 1 })]
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] SortFall(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.SortFall(array);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 1, 3 })]
            [TestCase(new int[] { 1, 3, 6, 2, 8 }, 8, ExpectedResult = new int[] { 1, 3, 6, 2 })]
            [TestCase(new int[] { 1, 2, 3, 6, 2, 8, 76, 95, 90, 2 }, 2, ExpectedResult = new int[] { 1, 3, 6, 8, 76, 95, 90 })]
            public int[] delByValueTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.delByValue(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 6)]
            [TestCase(new int[] { 7 }, ExpectedResult = 1)]
            public int ReturnLenrthTest(int[] array)
            {
                ArrayList actual = new ArrayList(array);
                actual.ReturnLenrth(array);
                return actual.ReturnLenrth(array);
            }

            [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1, 2, 3 })]
            [TestCase(new int[] { 1 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1 })]
            [TestCase(new int[] { }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5 })]
            public int[] AddArrayAtTheBegginingTest(int[] array, int[] a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddArrayAtTheBeggining(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 24, 25 }, ExpectedResult = new int[] { 1, 2, 24, 25, 3, 4, 5 })]
            [TestCase(new int[] { 1 }, 0, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, new int[] { 4, 5 }, ExpectedResult = new int[] { 23, 24, 25, 26, 27, 4, 5, 28, 29, 30 })]
            public int[] AddArrayByIndexTest(int[] array, int index, int[] a)
            {
                ArrayList actual = new ArrayList(array);
                actual.AddArrayByIndex(a, index);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 1 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, ExpectedResult = new int[] { 23, 24, 25 })]
            public int[] DelSeveralLastElTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.DelSeveralLastEl(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 3 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, ExpectedResult = new int[] { 28, 29, 30 })]
            public int[] delSeveralFirstElTest(int[] array, int a)
            {
                ArrayList actual = new ArrayList(array);
                actual.delSeveralFirstEl(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 8, 9, 0, 90 }, 2, 3, ExpectedResult = new int[] { 1, 2, 3, 0, 90 })]
            [TestCase(new int[] { 43, 45, 46, 789, 34, 23, 56, 345, 289, 976, 3, 5 }, 3, 4, ExpectedResult = new int[] { 43, 45, 46, 789, 345, 289, 976, 3, 5 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 4, 4, ExpectedResult = new int[] { 23, 24, 25, 26 })]
            public int[] delseveralElByIndexTest(int[] array, int a, int index)
            {
                ArrayList actual = new ArrayList(array);
                actual.delseveralElByIndex(a, index);
                return actual.ReturnArray();
            }



        }

    }
