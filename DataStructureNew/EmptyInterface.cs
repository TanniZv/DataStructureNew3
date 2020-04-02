using System;
namespace DataStructureNew
{
    
        public interface IList
        {

            int[] ReturnArray();
            public void AddAtTheEnd(int a);
            public void AddAtTheBeggining(int a);
            public void AddAccordingToIndex(int index, int a);
            public void DelTheLastEl();
            public void delTheFirstEl();
            public void delByIndex(int delIndex);
            public int ValueByIndex(int index);
            public int IndexByValue(int a);
            public void ChangeByIndex(int index, int a);
            public void Reverse();
            public int MaxElement();
            public int MinElement();
            public int MinIndex();
            public int MaxIndex(int[] a);
            public void SorRise(int[] a);
            public void SortFall(int[] a);
            public void delByValue(int a);
            public int ReturnLenrth(int[] a);
            public void AddArrayAtTheEnd(int[] a);
            public void AddArrayAtTheBeggining(int[] a);
            public void AddArrayByIndex(int[] a, int index);
            public void DelSeveralLastEl(int a);
            public void delSeveralFirstEl(int a);
            public void delseveralElByIndex(int a, int delIndex);

        }
    
}
