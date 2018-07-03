using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        private T[] listArray;

        //methods
        public void Add(T incomingElement)
        {
            T[] newArray = new T[Count()+1];
            for (int i = 0; i < Count(); i++)
            {
                newArray[i] = listArray[i];
            }
            newArray[Count()] = incomingElement;
        }

        public int Count()
        {
            int counter = 0;
            foreach (T element in listArray)
            {
                counter++;
            }
            return counter;
        }
    }
}
