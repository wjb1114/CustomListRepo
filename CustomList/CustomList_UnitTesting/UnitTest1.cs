using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomList_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemShouldGoToIndexZero()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 8;
            int actual;
            // act
            test.Add(8);
            actual = test[0];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToEmptyList_CountShouldIncreaseToOne()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            test.Add(8);
            actual = test.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToPopulatedList_ItemShouldGoToIndexLegth()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 8;
            int actual;
            // act
            test.Add(0);
            test.Add(8);
            actual = test[1];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToPopulatedList_CountShouldIncreaseByOne()
        {
            // arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 2;
            int actual;
            // act
            test.Add(0);
            test.Add(8);
            actual = test.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToPopulatedList_CreatedNewArrayWhenOutOfBoundsCount()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 9;
            int actual;
            // act
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            actual = test.Count;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToPopulatedList_CreatedNewArrayWhenOutOfBoundsValueExists_NewValueExists()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 8;
            int actual;
            // act
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            actual = test[8];
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToPopulatedList_CreatedNewArrayWhenOutOfBoundsValueExists_ArrayLengthUpdated()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 16;
            int actual;
            // act
            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            actual = test.Capacity;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AccessingItemInArray_OutOfBoundsWhenInArrayLengthButNotInList()
        {
            CustomList<int> test = new CustomList<int>();
            int actual;

            test.Add(0);
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            try
            {
                actual = test[5];
                Assert.Fail("Expected to fail due to value being out of range.");
            }
            catch (IndexOutOfRangeException e)
            {
                Assert.AreEqual("Index out of range.", e.Message);
            }
        }
    }
}
