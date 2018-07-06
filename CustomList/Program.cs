using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testList = new List<int>();
            //testList.Add(1);
            //testList.Add(2);
            //testList.Add(1);
            //foreach (int item in testList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Remove");
            //testList.Remove(1);
            //foreach (int item in testList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //string[] testArray = { "one", "two", "three" };
            //string joinedString = string.Join(",", testArray);
            //Console.WriteLine(joinedString);
            //Console.ReadLine();

            CustomList<int> minuendList = new CustomList<int> { 1, 2, 3 };
            CustomList<int> subtrahendList = new CustomList<int> { 2 };
            CustomList<int> differenceList;

            differenceList = minuendList - subtrahendList;

            foreach (int element in differenceList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
            /*
                Console Output:
                1
                3
            */
        }
    }
}
