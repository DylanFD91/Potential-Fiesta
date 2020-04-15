using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace UnitTestingPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToLowerMethod_GivingDifferentCasesOfCapitals_WillAlwaysLowerCaseTheString()
        {
            //arrange
            ThePool testMethods = new ThePool();
            string expectedResult = "madam", actualResult;

            //act
            testMethods.userInputOriginal = "MADAM";
            testMethods.LowerCaseUserInput();
            actualResult = testMethods.userInputLowerCased;

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            ThePool testMethods = new ThePool();
            char[] converter, expectedResult, actualResult;
            int arrayIndexCount;

            //Act
            testMethods.userInputLowerCased = "madam";
            arrayIndexCount = testMethods.userInputLowerCased.Length;
            testMethods.userInputBeingConverted = testMethods.userInputLowerCased;
            converter = testMethods.userInputBeingConverted.ToCharArray();
            expectedResult = converter;
            actualResult = testMethods.userInputInArray;
            //Assert
            Assert.AreEqual(expectedResult[arrayIndexCount], actualResult[arrayIndexCount]);
        }
    }
}
