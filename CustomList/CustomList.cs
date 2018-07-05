﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        private T[] listArray = new T[0];

        //accessors
        public T this [int index]
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
            T[] newArray = new T[currentCount+1];
            for (int i = 0; i < currentCount; i++)
            {
                newArray[i] = listArray[i];
            }
            newArray[currentCount] = incomingElement;
            listArray = newArray;
        }

        public bool Remove(T targetElement)
        {
            int currentCount = Count;
            T[] newArray = new T[currentCount - 1];
            for (int i = 0; i< currentCount; i++)
            {
                if (listArray[i].Equals(targetElement))
                {
                    for (int j = 0; j < i; j++)
                    {
                        newArray[j] = listArray[j];
                    }
                    for (int j = i+1; j < currentCount; j++)
                    {
                        newArray[j - 1] = listArray[j];
                    }
                    listArray = newArray;
                    return true;
                }
            }
            return false;
        }

        //public int Count()
        //{
        //    int counter = 0;
        //    foreach (T element in listArray)
        //    {
        //        counter++;
        //    }
        //    return counter;
        //}
    }
}
