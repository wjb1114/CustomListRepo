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
        [TestMethod]
        public void Remove_ArrayHasValues_CountDecrements()
        {
            int[] initVals = new int[4] {0, 1, 2, 3};
            CustomList<int> test = new CustomList<int>(initVals);
            int expected = 3;
            int actual;

            test.Remove(2);
            actual = test.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasValues_IndexesMove()
        {
            int[] initVals = new int[4] { 0, 1, 2, 3 };
            CustomList<int> test = new CustomList<int>(initVals);
            int expected = 3;
            int actual;

            test.Remove(2);
            actual = test[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasNoValues_CountDoesNotDecrement()
        {
            int[] initVals = new int[4] { 0, 1, 2, 3 };
            CustomList<int> test = new CustomList<int>(initVals);
            int expected = 4;
            int actual;

            test.Remove(4);
            actual = test.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasNoValues_IndexesDoNotMove()
        {
            CustomList<int> test = new CustomList<int>();
            int expected = 0;
            int actual;

            test.Remove(2);
            actual = test.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasNoValues_ReturnsFalse()
        {
            CustomList<int> test = new CustomList<int>();
            bool expected = false;
            bool actual;

            actual = test.Remove(2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasValues_ReturnsTrueIfValueFound()
        {
            int[] initVals = new int[4] { 0, 1, 2, 3 };
            CustomList<int> test = new CustomList<int>(initVals);
            bool expected = true;
            bool actual;

            actual = test.Remove(2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ArrayHasValues_ReturnsFalseIfValueNotFound()
        {
            int[] initVals = new int[4] { 0, 1, 2, 3 };
            CustomList<int> test = new CustomList<int>(initVals);
            bool expected = false;
            bool actual;

            actual = test.Remove(4);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ArrayHasValues_ReturnsStringWithLengthMoreThanZero()
        {
            CustomList<int> test = new CustomList<int>();
            int result;
            int minLength = 1;
            string output;

            test.Add(0);

            output = test.ToString();

            Assert.IsTrue(output.Length >= minLength);
        }
        [TestMethod]
        public void ToString_ArrayHasNoValues_ReturnsStringWithLengthZero()
        {
            CustomList<int> test = new CustomList<int>();
            int result;
            int expectedLength = 0;
            string output;

            output = test.ToString();

            Assert.AreEqual(expectedLength, output.Length);
        }
        [TestMethod]
        public void ToString_ArrayHasMultipleValues_ReturnsStringContainingComma()
        {
            CustomList<int> test = new CustomList<int>();
            bool result;
            bool expectedResult = true;
            string output;

            test.Add(0);
            test.Add(1);

            output = test.ToString();

            if (output.Contains(", "))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ToString_ArrayHasSingleValues_ReturnsStringWithoutComma()
        {
            CustomList<int> test = new CustomList<int>();
            bool result;
            bool expectedResult = false;
            string output;

            test.Add(0);

            output = test.ToString();

            if (output.Contains(", "))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.AreEqual(expectedResult, result);
        }
    }
}
