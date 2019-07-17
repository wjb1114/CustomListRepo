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
        public void Add_AddToPopulatedList_CreatedNewArrayWhenOutOfBoundsValueExists()
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
    }
}
