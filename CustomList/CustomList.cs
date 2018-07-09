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
        //member variables
        private T[] listArray = new T[0];

        //accessors
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

        //methods
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
            //return listArray.GetEnumerator();
            //return new CustomListEnumerator<T>(this);
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

        //public CustomList<T> Sort()
        //{
        //    //Uses QuickSort with the Lomuto partition scheme
        //    CustomList<T> sortList = new CustomList<T>();
        //    //for (int i = 0; i < this.Count; i++)
        //    //{
        //    //    string currentValue = this[i].ToString();
        //    //    sortList.Add(int.Parse(currentValue));
        //    //}

        //    QuickSort(sortList, 0, this.Count - 1);
        //    return sortList;
        //}

        //public void QuickSort(CustomList<T> List, int lo, int hi)
        //{
        //    if (lo < hi)
        //    {
        //        int currentPivot = Partition(List, lo, hi);
        //        QuickSort(List, lo, currentPivot - 1);
        //        QuickSort(List, currentPivot + 1, hi);
        //    }
        //}

        //public int Partition(CustomList<T> List, int lo, int hi)
        //{
        //    T pivot = List[hi];
        //    int index = lo - 1;
        //    for (int j = lo; j <= hi -1; j++)
        //    {
        //        if (List[j].CompareTo(pivot) < 0)
        //        {
        //            index++;
        //            T holder1 = List[index];
        //            T holder2 = List[j];

        //            List[index] = holder2;
        //            List[j] = holder1;
        //        }
        //    }
        //    T outerHolder1 = List[index + 1];
        //    T outerHolder2 = List[hi];

        //    List[index + 1] = outerHolder2;
        //    List[hi] = outerHolder1;
        //    return index + 1;
        //}

        public string ToString(string separator)
        {
            StringBuilder output = new StringBuilder();
            int currentCount = Count;
            for (int i = 0; i < currentCount; i++)
            {
                output.Append(listArray[i]);
                if (i + 1 < currentCount)
                {
                    output.Append(separator);
                }
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

//    public class CustomListEnumerator<T> :  IEnumerator<T>
//    {
//        CustomList<T> parentList;
//        public int currentIndex = -1;

//        public CustomListEnumerator(CustomList<T> customList)
//        {
//            parentList = customList;
//        }

//        public T Current
//        {
//            get
//            {
//                return parentList[currentIndex];
//            }
//        }

//        object IEnumerator.Current
//        {
//            get { return Current; }
//        }

//        public bool MoveNext()
//        {
//            currentIndex++;
//            if (currentIndex < parentList.Count)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public void Dispose()
//        {
            
//        }

//        public void Reset()
//        {
//            currentIndex = -1;
//        }
//    }
}
