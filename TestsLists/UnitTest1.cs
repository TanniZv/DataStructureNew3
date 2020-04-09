using NUnit.Framework;
using DataStructureNew;

namespace TestsLists
{
    namespace Tests
    {
        [TestFixture(1)]
        [TestFixture(2)]
        [TestFixture(3)]

        public class ListTest
        {
            IList actual;
            int q;

            public ListTest(int _q)
            {
                q = _q;
            }

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

                    case 3:
                        actual = new L2List();
                        break;

                }
            }

            [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 4, 1, 2, 3 })]
            [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
            public int[] AddAtTheBegginingTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddAtTheBeggining(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 7, ExpectedResult = new int[] { 1, 2, 3, 7 })]
            [TestCase(new int[] { 1 }, 7, ExpectedResult = new int[] { 1, 7 })]
            [TestCase(new int[] { }, 7, ExpectedResult = new int[] { 7 })]
            public int[] AddAtTheEndTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddAtTheEnd(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
            [TestCase(new int[] { }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5 })]
            [TestCase(new int[] { 1, }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 4, 5 })]
            public int[] AddArrayAtTheEndTest(int[] array, int[] a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddArrayAtTheEnd(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 1, 2, 3 })]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 7, 8, 9 }, 3, 9, ExpectedResult = new int[] { 1, 2, 3, 9, 4, 5, 7, 8, 9 })]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 7, 90, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 90, 8, 9, })]
            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 9, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 9 })]
            public int[] AddAccordingToIndexTest(int[] array, int index, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddAccordingToIndex(index, a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2 })]
            [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
            public int[] DelTheLastElTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.DelTheLastEl();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 2, 3 })]
            [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
            public int[] delTheFirstElTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.delTheFirstEl();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 2, 3 })]
            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, 4, ExpectedResult = new int[] { 1, 2, 3, 54, 23 })]
            [TestCase(new int[] { 1, 2, 3, 54 }, 3, ExpectedResult = new int[] { 1, 2, 3 })]
            public int[] delByIndexTest(int[] array, int index)
            {
                actual.AddArrayAtTheEnd(array);
                actual.delByIndex(index);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 4, 73, 23 }, 4, ExpectedResult = 73)]
            [TestCase(new int[] { 1, 2, 3, 4, 73, 23, 1, 2, 3, 100 }, 7, ExpectedResult = 2)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 5, ExpectedResult = 23)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 3, ExpectedResult = 74)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 0, ExpectedResult = 1)]
            public int ValueByIndexTest(int[] array, int index)
            {
                actual.AddArrayAtTheEnd(array);
                actual.ValueByIndex(index);
                return actual.ValueByIndex(index);
            }

            [TestCase(new int[] { 1, 2, 3, 4, 73, 23 }, 4, ExpectedResult = 3)]
            [TestCase(new int[] { 1, 2, 3, 74, 73, 23 }, 4, ExpectedResult = -1)]
            public int IndexByValuexTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.IndexByValue(a);
                return actual.IndexByValue(a);
            }


            [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 2, 3 })]
            [TestCase(new int[] { 1, 2, 3, 4 }, 2, 9, ExpectedResult = new int[] { 1, 2, 9, 4 })]
            [TestCase(new int[] { 1, 2, 3, 4 }, 3, 9, ExpectedResult = new int[] { 1, 2, 3, 9 })]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 4, 9, ExpectedResult = new int[] { 1, 2, 3, 4, 9, 6 })]
            public int[] ChangeByIndexTest(int[] array, int index, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.ChangeByIndex(index, a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 4, 3 }, ExpectedResult = new int[] { 3, 4, 2, 1 })]
            [TestCase(new int[] { 7, 6, 5, 4, 3 }, ExpectedResult = new int[] { 3, 4, 5, 6, 7 })]//3, 4, 5, 6, 7
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] ReverseTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.Reverse();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 73)]
            [TestCase(new int[] { 7 }, ExpectedResult = 7)]
            public int MaxElementTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.MaxElement();
                return actual.MaxElement();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 1)]
            [TestCase(new int[] { 1, 2, 3, -54, 73, 23 }, ExpectedResult = -54)]
            [TestCase(new int[] { 7 }, ExpectedResult = 7)]
            public int MinElementTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.MinElement();
                return actual.MinElement();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 4)]
            [TestCase(new int[] { 7 }, ExpectedResult = 0)]
            public int MaxIndexTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.MaxIndex();
                return actual.MaxIndex();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 0)]
            [TestCase(new int[] { 1, -200, 3, 54, -73, -23000 }, ExpectedResult = 5)]
            [TestCase(new int[] { 1, -200, 3, 54, -73, 23 }, ExpectedResult = 1)]
            [TestCase(new int[] { 10, 2, 3, 54, -73, 23 }, ExpectedResult = 4)]
            [TestCase(new int[] { 1, 2, 3, 54, 73, -23, 90, 80, 70 }, ExpectedResult = 5)]
            [TestCase(new int[] { 7 }, ExpectedResult = 0)]
            public int MinIndexTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.MinIndex();
                return actual.MinIndex();
            }

            [TestCase(new int[] { 1, 2, 3, -1, -2 }, ExpectedResult = new int[] { -2, -1, 1, 2, 3 })]
            [TestCase(new int[] { 7, 6, 5, 4, 3 }, ExpectedResult = new int[] { 3, 4, 5, 6, 7 })]
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] SortRiseTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.SortRise();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 })]
            [TestCase(new int[] { 7, 6, 1, 4, 3 }, ExpectedResult = new int[] { 7, 6, 4, 3, 1 })]
            [TestCase(new int[] { 7 }, ExpectedResult = new int[] { 7 })]
            public int[] SortFall(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.SortFall();
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 1, 3 })]
            [TestCase(new int[] { 1, 1, 1, 2, 3 }, 1, ExpectedResult = new int[] { 2, 3 })]
            [TestCase(new int[] { 1, 3, 6, 2, 8 }, 8, ExpectedResult = new int[] { 1, 3, 6, 2 })]
            [TestCase(new int[] { 1, 2, 2, 3, 6, 2, 8, 76, 95, 90, 2 }, 2, ExpectedResult = new int[] { 1, 3, 6, 8, 76, 95, 90 })]
            public int[] delByValueTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.delByValue(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 54, 73, 23 }, ExpectedResult = 6)]
            [TestCase(new int[] { 7 }, ExpectedResult = 1)]
            public int ReturnLenrthTest(int[] array)
            {
                actual.AddArrayAtTheEnd(array);
                actual.ReturnLenrth();
                return actual.ReturnLenrth();
            }

            [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1, 2, 3 })]
            [TestCase(new int[] { 1 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1 })]
            [TestCase(new int[] { }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5 })]
            public int[] AddArrayAtTheBegginingTest(int[] array, int[] a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddArrayAtTheBeggining(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 24, 25 }, ExpectedResult = new int[] { 1, 2, 24, 25, 3, 4, 5 })]
            [TestCase(new int[] { 1 }, 0, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1 })]
            [TestCase(new int[] { 1 }, 1, new int[] { 4, 5 }, ExpectedResult = new int[] { 1,4, 5 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, new int[] { 4, 5 }, ExpectedResult = new int[] { 23, 24, 25, 26, 27, 4, 5, 28, 29, 30 })]
            [TestCase(new int[] { 2, 20, 30, 40, 9, 8, 6, 2 }, 6, new int[] { 4, 5 }, ExpectedResult = new int[] { 2, 20, 30, 40, 9, 8, 4, 5, 6, 2 })]
            public int[] AddArrayByIndexTest(int[] array, int index, int[] a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.AddArrayByIndex(a, index);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 1 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, ExpectedResult = new int[] { 23, 24, 25 })]
            public int[] DelSeveralLastElTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.DelSeveralLastEl(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 3 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 5, ExpectedResult = new int[] { 28, 29, 30 })]
            public int[] delSeveralFirstElTest(int[] array, int a)
            {
                actual.AddArrayAtTheEnd(array);
                actual.delSeveralFirstEl(a);
                return actual.ReturnArray();
            }

            [TestCase(new int[] { 1, 2, 3, 8, 9, 0, 90 }, 2, 3, ExpectedResult = new int[] { 1, 2, 3, 0, 90 })]
            [TestCase(new int[] { 1, 2, 3, 8, 9, 0, 90 }, 2, 0, ExpectedResult = new int[] { 3, 8, 9, 0, 90 })]
            [TestCase(new int[] { 43, 45, 46, 789, 34, 23, 56, 345, 289, 976, 3, 5 }, 3, 4, ExpectedResult = new int[] { 43, 45, 46, 789, 345, 289, 976, 3, 5 })]
            [TestCase(new int[] { 23, 24, 25, 26, 27, 28, 29, 30 }, 4, 4, ExpectedResult = new int[] { 23, 24, 25, 26 })]
            public int[] delseveralElByIndexTest(int[] array, int a, int index)
            {
                actual.AddArrayAtTheEnd(array);
                actual.delseveralElByIndex(a, index);
                return actual.ReturnArray();
            }
        }
    }
}