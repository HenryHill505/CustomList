using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] listArray = new T[0];

        public T this[int index]
        {
            get
            {
                return listArray[index];
            }

            set
            {
                listArray[index] = value;
            }
        }

        public int Count
        {
            get
            {
                int counter = 0;
                foreach (T element in listArray)
                {
                    counter++;
                }
                return counter;
            }
        }

        public void Add(T incomingElement)
        {
            int currentCount = Count;
            T[] newArray = new T[currentCount + 1];
            for (int i = 0; i < currentCount; i++)
            {
                newArray[i] = listArray[i];
            }
            newArray[currentCount] = incomingElement;
            listArray = newArray;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return listArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static CustomList<T> operator+(CustomList<T> customList1,CustomList<T> customList2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < customList1.Count; i++)
            {
                newList.Add(customList1[i]);
            }
            for (int i = 0; i < customList2.Count; i++)
            {
                newList.Add(customList2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator-(CustomList<T> minuendList, CustomList<T> subtrahendList)
        {
            CustomList<T> newList = new CustomList<T>();
            bool beKept;
            for (int i = 0; i < minuendList.Count; i++)
            {
                beKept = true;
                for (int j = 0; j < subtrahendList.Count; j++)
                {
                    if (minuendList[i].Equals(subtrahendList[j])) { beKept = false; }
                }
                if (beKept) { newList.Add(minuendList[i]); }
            }
            return newList;
        }

        public bool Remove(T targetElement)
        {
            int currentCount = Count;
            T[] newArray = new T[currentCount - 1];
            for (int i = 0; i < currentCount; i++)
            {
                if (listArray[i].Equals(targetElement))
                {
                    for (int j = 0; j < i; j++)
                    {
                        newArray[j] = listArray[j];
                    }
                    for (int j = i + 1; j < currentCount; j++)
                    {
                        newArray[j - 1] = listArray[j];
                    }
                    listArray = newArray;
                    return true;
                }
            }
            return false;
        }

        //Uses QuickSort with the Lomuto partition scheme
        public void Sort()
        {
            QuickSort(this, 0, this.Count - 1);
        }

        public void QuickSort(CustomList<T> List, int indexLo, int indexHi)
        {
            if (indexLo < indexHi)
            {
                int currentPivot = Partition(List, indexLo, indexHi);
                QuickSort(List, indexLo, currentPivot - 1);
                QuickSort(List, currentPivot + 1, indexHi);
            }
        }

        public int Partition(CustomList<T> List, int indexLo, int indexHi) 
        {
            T pivot = List[indexHi];
            int index = indexLo - 1;
            for (int j = indexLo; j <= indexHi - 1; j++)
            {
                try
                {
                    if (Comparer<T>.Default.Compare(List[j], pivot) < 0)
                    {
                        index++;
                        T innerTemporary = List[index];

                        List[index] = List[j];
                        List[j] = innerTemporary;
                    }
                }
                catch (ArgumentException exception)
                {
                    throw (exception);
                }
            }
            T outerTemporary = List[index + 1];

            List[index + 1] = List[indexHi];
            List[indexHi] = outerTemporary;
            return index + 1;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            int currentCount = Count;
            for (int i = 0; i < currentCount; i++)
            {
                output.Append(listArray[i]);
            }
            return output.ToString();
        }

        public CustomList<T> Zip(CustomList<T> zipList)
        {
            CustomList<T> newList = new CustomList<T>();
            int zipCounter;

            if (this.Count >= zipList.Count)
            {
                zipCounter = this.Count;
            }
            else
            {
                zipCounter = zipList.Count;
            }

            for (int i = 0; i < zipCounter; i++)
            {
                if (i < this.Count) { newList.Add(this[i]); }
                if (i < zipList.Count) { newList.Add(zipList[i]); }
            }
            return newList;
        }
    }
}
