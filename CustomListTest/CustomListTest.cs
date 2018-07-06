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

        //Need to implement IEnumerable or these tests will prevent the other tests from running

        [TestMethod]
        public void AddViaBrace_SingleString_ReturnSingleString()
        {
            //Arrange
            string value = "one";
            //Act
            CustomList<string> customList = new CustomList<string>() { value };
            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void AddViaBrace_TwoStrings_ReturnBothStrings()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            //Act
            CustomList<string> customList = new CustomList<string>() { value1, value2 };
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void AddViaBrace_SingleInteger_ReturnSingleInteger()
        {
            //Arrange
            int value = 1;
            //Act
            CustomList<int> customList = new CustomList<int>() { value };
            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void AddViaBrace_TwoIntegers_ReturnBothIntegers()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            //Act
            CustomList<int> customList = new CustomList<int>() { value1, value2 };
            //Assert
            Assert.AreEqual(value1, customList[0]);
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Iterate_MultipleIntegers_CheckEachIndex()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int valueCounter = 1;
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            //Assert
            foreach (int value in customList)
            {
                Assert.AreEqual(valueCounter, value);
                valueCounter++;
            }
        } 

        [TestMethod]
        public void CountAfterAdd_MultipleIntegers_ReturnNumberOfIntegers()
        {
            //Arrage
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int numberOfValues = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            //Assert
            Assert.AreEqual(numberOfValues, customList.Count);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtraHendListHasOneMatchingValue_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 2 };
            CustomList<int> differenceList;
            int expectedCount = 2;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtraHendListHasOneMatchingValue_DifferenceListHasCorrectValues()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 2 };
            CustomList<int> differenceList;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(1, differenceList[0]);
            Assert.AreEqual(1, differenceList[1]);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtrahendListHasOneMatchingValueWithDuplicates_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 2, 2 };
            CustomList<int> differenceList;
            int expectedCount = 2;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtrahendListHasOneMatchingValueWithDuplicates_DifferenceListHasCorrectValues()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 2, 2 };
            CustomList<int> differenceList;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(1, differenceList[0]);
            Assert.AreEqual(1, differenceList[1]);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtraHendListMatchesAllValues_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 1, 2 };
            CustomList<int> differenceList;
            int expectedCount = 0;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_IntegerSubtrahendListHasNoMatchingValues_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<int> minuendList = new CustomList<int> { 1, 1, 2, 2 };
            CustomList<int> subtrahendList = new CustomList<int> { 3, 4, 5 };
            CustomList<int> differenceList;
            int expectedCount = 4;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtraHendListHasOneMatchingValue_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "two" };
            CustomList<string> differenceList;
            int expectedCount = 2;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtraHendListHasOneMatchingValue_DifferenceListHasCorrectValues()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "two" };
            CustomList<string> differenceList;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual("one", differenceList[0]);
            Assert.AreEqual("one", differenceList[1]);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtrahendListHasOneMatchingValueWithDuplicates_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "two", "two" };
            CustomList<string> differenceList;
            int expectedCount = 2;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtrahendListHasOneMatchingValueWithDuplicates_DifferenceListHasCorrectValues()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "two", "two" };
            CustomList<string> differenceList;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual("one", differenceList[0]);
            Assert.AreEqual("one", differenceList[1]);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtraHendListMatchesAllValues_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "one", "two" };
            CustomList<string> differenceList;
            int expectedCount = 0;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadMinus_StringSubtrahendListHasNoMatchingValues_DifferenceListHasCorrectCount()
        {
            //Arrange
            CustomList<string> minuendList = new CustomList<string> { "one", "one", "two", "two" };
            CustomList<string> subtrahendList = new CustomList<string> { "three", "four", "five" };
            CustomList<string> differenceList;
            int expectedCount = 4;
            //Act
            differenceList = minuendList - subtrahendList;
            //Assert
            Assert.AreEqual(expectedCount, differenceList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoIntegerListsOfEqualLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6 };
            int expectedCount = 6;
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoIntegerListsOfEqualLength_SumListHasCorrectValuesAtCorrectIndices()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6 };
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            for (int i = 0; i <= 2; i++)
            {
                Assert.AreEqual(customList1[i], sumList[i]);
                Assert.AreEqual(customList2[i], sumList[i+3]);
            }
        }

        [TestMethod]
        public void OverloadPlus_AddThreeIntegerListsOfEqualLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6 };
            CustomList<int> customList3 = new CustomList<int> { 7, 8, 9 };
            int expectedCount = 9;
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2 + customList3;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddThreeIntegerListsOfEqualLength_SumListHasCorrectValuesAtCorrectIndices()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6 };
            CustomList<int> customList3 = new CustomList<int> { 7, 8, 9 };
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2 + customList3;
            //Assert
            for (int i = 0; i <= 2; i++)
            {
                Assert.AreEqual(customList1[i], sumList[i]);
                Assert.AreEqual(customList2[i], sumList[i + 3]);
                Assert.AreEqual(customList3[i], sumList[i + 6]);
            }
        }

        [TestMethod]
        public void OverloadPlus_AddTwoIntegerListsOfUnequalLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6, 7, 8, 9};
            int expectedCount = 9;
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoIntegerListsOfUnequalLength_SumListHasCorrectLastValue()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> customList2 = new CustomList<int> { 4, 5, 6, 7, 8, 9};
            CustomList<int> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual(9, sumList[8]);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoStringListsOfEqualLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six" };
            int expectedCount = 6;
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoStringListsOfEqualLength_SumListHasCorrectValuesAtCorrectIndices()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six" };
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            for (int i = 0; i <= 2; i++)
            {
                Assert.AreEqual(customList1[i], sumList[i]);
                Assert.AreEqual(customList2[i], sumList[i + 3]);
            }
        }

        [TestMethod]
        public void OverloadPlus_AddThreeStringListsOfEqualLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six" };
            CustomList<string> customList3 = new CustomList<string> { "seven", "eight", "nine" };
            int expectedCount = 9;
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2 + customList3;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddThreeStringListsOfEqualLength_SumListHasCorrectValuesAtCorrectIndices()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six" };
            CustomList<string> customList3 = new CustomList<string> { "seven", "eight", "nine" };
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2 + customList3;
            //Assert
            for (int i = 0; i <= 2; i++)
            {
                Assert.AreEqual(customList1[i], sumList[i]);
                Assert.AreEqual(customList2[i], sumList[i + 3]);
                Assert.AreEqual(customList3[i], sumList[i + 6]);
            }
        }

        [TestMethod]
        public void OverloadPlus_AddTwoStringListsOfUnequalLength_SumListHasCorrectCount()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six", "seven", "eight", "nine" };
            int expectedCount = 9;
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual(expectedCount, sumList.Count);
        }

        [TestMethod]
        public void OverloadPlus_AddTwoStringListsOfEqualLength_SumListHasCorrectLastValue()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string> { "one", "two", "three" };
            CustomList<string> customList2 = new CustomList<string> { "four", "five", "six", "seven", "eight", "nine" };
            CustomList<string> sumList;
            //Act
            sumList = customList1 + customList2;
            //Assert
            Assert.AreEqual("nine", sumList[8]);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtEnd_CheckIndex0()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int removeValue = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtEnd_CheckIndex1()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int removeValue = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtEnd_CheckListCount()
        {
            //Arrange
            int expectedCount = 2;
            int value1 = 1;
            int value2 = 2;
            int removeValue = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtEnd_ReturnTrue()
        {
            //Arrange
            bool didRemoveSucceed;
            int value1 = 1;
            int value2 = 2;
            int removeValue = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtBeginning_CheckIndex0()
        {
            //Arrange
            int removeValue = 1;
            int value1 = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtBeginning_CheckIndex1()
        {
            //Arrange
            int removeValue = 1;
            int value1 = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtBeginning_CheckListCount()
        {
            //Arrange
            int expectedCount = 2;
            int removeValue = 1;
            int value1 = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleIntegerAtBeginning_ReturnTrue()
        {
            //Arrange
            bool didRemoveSucceed;
            int removeValue = 1;
            int value1 = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_SingleIntegerInMiddle_CheckIndex0()
        {
            //Arrange
            int value1 = 1;
            int removeValue = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleIntegerInMiddle_CheckIndex1()
        {
            //Arrange
            int value1 = 1;
            int removeValue = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleIntegerInMiddle_CheckListCount()
        {
            //Arrange
            int expectedCount = 2;
            int value1 = 1;
            int removeValue = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleIntegerInMiddle_ReturnTrue()
        {
            //Arrange
            bool didRemoveSucceed;
            int value1 = 1;
            int removeValue = 2;
            int value2 = 3;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_IntegerThatIsNotThere_CheckIndex0()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int nonExistantValue = 4;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_IntegerThatIsNotThere_CheckIndex1()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int nonExistantValue = 4;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_IntegerThatIsNotThere_CheckIndex2()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int nonExistantValue = 4;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value3, customList[2]);
        }

        [TestMethod]
        public void Remove_IntegerThatIsNotThere_CheckListCount()
        {
            //Arrange
            int expectedCount = 3;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int nonExistantValue = 4;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_IntegerThatIsNotThere_ReturnFalse()
        {
            //Arrange
            bool didRemoveSucceed;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int nonExistantValue = 4;
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            didRemoveSucceed = customList.Remove(nonExistantValue);
            //Assert
            Assert.IsFalse(didRemoveSucceed);
        }




        [TestMethod]
        public void Remove_SingleStringAtEnd_CheckIndex0()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string removeValue = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleStringAtEnd_CheckIndex1()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string removeValue = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleStringAtEnd_CheckListCount()
        {
            //Arrange
            int expectedCount = 2;
            string value1 = "one";
            string value2 = "two";
            string removeValue = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleStringAtEnd_ReturnFalse()
        {
            //Arrange
            bool didRemoveSucceed;
            string value1 = "one";
            string value2 = "two";
            string removeValue = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(removeValue);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_SingleStringAtBeginning_CheckIndex0()
        {
            //Arrange
            string removeValue = "one";
            string value1 = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleStringAtBeginning_CheckIndex1()
        {
            //Arrange
            string removeValue = "one";
            string value1 = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleStringAtBeginning_CheckCount()
        {
            //Arrange
            int expectedCount = 2;
            string removeValue = "one";
            string value1 = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleStringAtBeginning_ReturnTrue()
        {
            //Arrange
            bool didRemoveSucceed;
            string removeValue = "one";
            string value1 = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(removeValue);
            customList.Add(value1);
            customList.Add(value2);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_SingleStringInMiddle_CheckIndex0()
        {
            //Arrange
            string value1 = "one";
            string removeValue = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_SingleStringInMiddle_CheckIndex1()
        {
            //Arrange
            string value1 = "one";
            string removeValue = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_SingleStringInMiddle_CheckListCount()
        {
            //Arrange
            int expectedCount = 2;
            string value1 = "one";
            string removeValue = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            customList.Remove(removeValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_SingleStringInMiddle_ReturnTrue()
        {
            //Arrange
            bool didRemoveSucceed;
            string value1 = "one";
            string removeValue = "two";
            string value2 = "three";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(removeValue);
            customList.Add(value2);

            didRemoveSucceed = customList.Remove(removeValue);
            //Assert
            Assert.IsTrue(didRemoveSucceed);
        }

        [TestMethod]
        public void Remove_StringThatIsNotThere_CheckIndex0()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string nonExistantValue = "four";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_StringThatIsNotThere_CheckIndex1()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string nonExistantValue = "four";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value2, customList[1]);
        }

        [TestMethod]
        public void Remove_StringThatIsNotThere_CheckIndex2()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string nonExistantValue = "four";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(value3, customList[2]);
        }

        [TestMethod]
        public void Remove_StringThatIsNotThere_CheckListCount()
        {
            //Arrange
            int expectedCount = 3;
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string nonExistantValue = "four";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            customList.Remove(nonExistantValue);
            //Assert
            Assert.AreEqual(expectedCount, customList.Count);
        }

        [TestMethod]
        public void Remove_StringThatIsNotThere_ReturnFalse()
        {
            //Arrange
            bool didRemoveSucceed;
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string nonExistantValue = "four";
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            didRemoveSucceed = customList.Remove(nonExistantValue);
            //Assert
            Assert.IsFalse(didRemoveSucceed);
        }

        [TestMethod]
        public void ToString_ThreeIntegers_CommaAndSpaceSeparatedString()
        {
            //Arrange
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            string separator = ", ";
            string expected = "1, 2, 3";
            string actual;
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList.ToString(separator);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThreeStrings_CommaAndSpaceSeparatedString()
        {
            //Arrange
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string separator = ", ";
            string expected = "one, two, three";
            string actual;
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList.ToString(separator);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThreeObjects_CommaAndSpaceSeparatedString()
        {
            //Arrange
            Object value1 = "one";
            Object value2 = "two";
            Object value3 = "three";
            string separator = ", ";
            string expected = "one, two, three";
            string actual;
            CustomList<Object> customList = new CustomList<Object>();
            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actual = customList.ToString(separator);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Zip_TwoEqualLengthListsOfIntegers_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultList;
            int expectedCount = 6;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        public void Zip_TwoEqualLengthListsOfIntegers_NewListInProperOrder()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            for (int i = 0; i < resultList.Count; i += 2)
            {
                Assert.AreEqual(customList1[i / 2], resultList[i]);
                Assert.AreEqual(customList2[i / 2], resultList[i + 1]);
            }
        }

        [TestMethod]

        public void Zip_TwoEqualLengthListsOfStrings_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six" };
            CustomList<string> resultList;
            int expectedCount = 6;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        [TestMethod]

        public void Zip_TwoEqualLengthListsOfStrings_NewListInProperOrder()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six" };
            CustomList<string> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            for (int i = 0; i < resultList.Count; i += 2)
            {
                Assert.AreEqual(customList1[i / 2], resultList[i]);
                Assert.AreEqual(customList2[i / 2], resultList[i + 1]);
            }
        }

        [TestMethod]

        public void Zip_ListsOfIntegersFirstListIsLonger_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultList;
            int expectedCount = 7;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        [TestMethod]

        public void Zip_ListsOfIntegersFirstListIsLonger_LastElementIsCorrect()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(7, resultList[6]);
        }

        [TestMethod]

        public void Zip_ListsOfIntegersSecondListIsLonger_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6, 7 };
            CustomList<int> resultList;
            int expectedCount = 7;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        [TestMethod]

        public void Zip_ListsOfIntegersSecondListIsLonger_LastElementIsCorrect()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 4, 6, 7 };
            CustomList<int> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(7, resultList[6]);
        }

        [TestMethod]

        public void Zip_ListsOfStringsFirstListIsLonger_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five", "seven" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six" };
            CustomList<string> resultList;
            int expectedCount = 7;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        [TestMethod]

        public void Zip_ListsOfStringsFirstListIsLonger_LastElementIsCorrect()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five", "seven" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six" };
            CustomList<string> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual("seven", resultList[6]);
        }

        [TestMethod]

        public void Zip_ListsOfStringsSecondListIsLonger_CountEqualToCountOfZippedLists()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six", "seven" };
            CustomList<string> resultList;
            int expectedCount = 7;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual(expectedCount, resultList.Count);
        }

        [TestMethod]

        public void Zip_ListsOfStringsSecondListIsLonger_LastElementIsCorrect()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>() { "one", "three", "five" };
            CustomList<string> customList2 = new CustomList<string>() { "two", "four", "six", "seven" };
            CustomList<string> resultList;
            //Act
            resultList = customList1.Zip(customList2);
            //Assert
            Assert.AreEqual("seven", resultList[6]);
        }
    }
}

