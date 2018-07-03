using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_SingleInteger_ReturnSingleInteger()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 1;
            //Act
            customList.Add(value);
            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void Add_TwoIntegers_ReturnBothIntegers()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            //Act
            customList.Add(value1);
            customList.Add(value2);
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Add_SingleObject_ReturnSingleObject()
        {
            //Arrange
            CustomList<Object> customList = new CustomList<Object>();
            Object value = new Object();
            //Act
            customList.Add(value);
            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void Add_TwoObjects_ReturnBothObjects()
        {
            //Arrange
            CustomList<Object> customList = new CustomList<Object>();
            Object value1 = new Object();
            Object value2 = new Object();
            //Act
            customList.Add(value1);
            customList.Add(value2);
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Add_SingleString_ReturnSingleInteger()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Hello";
            //Act
            customList.Add(value);
            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void Add_TwoStrings_ReturnBothStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value1 = "Hello";
            string value2 = "Goodbye";
            //Act
            customList.Add(value1);
            customList.Add(value2);
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
        }

        

        //[TestMethod]
        //public void AddViaBrace_SingleObject_ReturnSingleObject()
        //{
        //    //Arrange
        //    Object value = new object();
        //    //Act
        //    CustomList<Object> customList = new CustomList<Object>() { value };
        //    //Assert
        //    Assert.AreEqual(value, customList[0]);   
        //}

        //[TestMethod]
        //public void AddViaBrace_TwoObjects_ReturnBothObjects()
        //{
        //    //Arrange
        //    Object value1 = new object();
        //    Object value2 = new object();
        //    //Act
        //    CustomList<Object> customList = new CustomList<Object>() { value1, value2 };
        //    //Assert
        //    Assert.AreEqual(value1, customList[0]);
        //    Assert.AreEqual(value2, customList[1]);
        //}

        [TestMethod]
        public void CountAfterAdd_MultipleIntegers_ReturnNumberOfIntegers()
        {
            //Arrage
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
            Assert.AreEqual(value3, customList[2]);
        }
    }
}

