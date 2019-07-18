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
            int minLength = 1;
            int result;
            string output;

            test.Add(0);

            output = test.ToString();
            result = output.Length;

            Assert.IsTrue(result >= minLength);
        }
        [TestMethod]
        public void ToString_ArrayHasNoValues_ReturnsStringWithLengthZero()
        {
            CustomList<int> test = new CustomList<int>();
            int result;
            int expectedLength = 0;
            string output;

            output = test.ToString();
            result = output.Length;

            Assert.AreEqual(expectedLength, result);
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
        [TestMethod]
        public void PlusOperator_TwoCustomListsBothWithValues_ReturnsCombinedCustomList()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 3, 4, 5 };
            int[] expectedVals = new int[6] { 0, 1, 2, 3, 4, 5 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> result;
            CustomList<int> expectedResult = new CustomList<int>(expectedVals);
            bool resultBool = true;

            result = testOne + testTwo;
            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void PlusOperator_TwoCustomListsBothWithValues_CountIncrements()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 3, 4, 5 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> resultList;
            int result;
            int expectedResult = 6;

            resultList = testOne + testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PlusOperator_TwoCustomListsOneWithValues_ReturnsCombinedCustomList()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> result;
            CustomList<int> expectedResult = testOne;
            bool resultBool = true;

            result = testOne + testTwo;

            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void PlusOperator_TwoCustomListsOneWithValues_CountIncrements()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> resultList;
            int result;
            int expectedResult = 3;

            resultList = testOne + testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PlusOperator_TwoCustomListsNeitherWithValues_ReturnsCombinedCustomList()
        {
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> result;
            CustomList<int> expectedResult = testOne;
            bool resultBool = true;

            result = testOne + testTwo;

            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void PlusOperator_TwoCustomListsNeitherWithValues_CountIncrements()
        {
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> resultList;
            int result;
            int expectedResult = 0;

            resultList = testOne + testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValuesWithMatches_ReturnsCombinedCustomList()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 2, 3, 4 };
            int[] expectedVals = new int[2] { 0, 1 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> result;
            CustomList<int> expectedResult = new CustomList<int>(expectedVals);
            bool resultBool = true;

            result = testOne - testTwo;
            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValuesWithMatches_CountDecrements()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 2, 3, 4 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> resultList;
            int result;
            int expectedResult = 2;

            resultList = testOne - testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValuesWithoutMatches_ReturnsCombinedCustomList()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 3, 4, 5 };
            int[] expectedVals = new int[3] { 0, 1, 2 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> result;
            CustomList<int> expectedResult = new CustomList<int>(expectedVals);
            bool resultBool = true;

            result = testOne - testTwo;
            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValuesWithoutMatches_CountDoesNotDecrement()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            int[] valsTwo = new int[3] { 3, 4, 5 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> resultList;
            int result;
            int expectedResult = 3;

            resultList = testOne - testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsOneWithValues_ReturnsCombinedCustomList()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> result;
            CustomList<int> expectedResult = testOne;
            bool resultBool = true;

            result = testOne - testTwo;

            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsOneWithValues_CountDoesNotDecrement()
        {
            int[] valsOne = new int[3] { 0, 1, 2 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> resultList;
            int result;
            int expectedResult = 3;

            resultList = testOne - testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsNeitherWithValues_ReturnsEmptyList()
        {
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> result;
            CustomList<int> expectedResult = testOne;
            bool resultBool = true;

            result = testOne - testTwo;

            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsNeitherWithValues_CountDoesNotDecrement()
        {
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> resultList;
            int result;
            int expectedResult = 0;

            resultList = testOne - testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValuesMultiples_CountDoesDecrements()
        {
            int[] valsOne = new int[3] { 1, 1, 1 };
            int[] valsTwo = new int[3] { 1, 2, 3 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> resultList;
            int result;
            int expectedResult = 2;

            resultList = testOne - testTwo;
            result = resultList.Count;

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void MinusOperator_TwoCustomListsBothWithValues_ReturnsModifiedList()
        {
            int[] valsOne = new int[3] { 1, 1, 1 };
            int[] valsTwo = new int[3] { 1, 2, 3 };
            int[] expectedVals = new int[2] { 1, 1 };
            CustomList<int> testOne = new CustomList<int>(valsOne);
            CustomList<int> testTwo = new CustomList<int>(valsTwo);
            CustomList<int> result;
            CustomList<int> expectedResult = new CustomList<int>(expectedVals);
            bool resultBool = true;

            result = testOne - testTwo;

            if (result.Count != expectedResult.Count)
            {
                Assert.Fail("CustomList objects are of inequal length.");
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] != expectedResult[i])
                    {
                        resultBool = false;
                        break;
                    }
                }
                Assert.IsTrue(resultBool);
            }
        }
    }
}
