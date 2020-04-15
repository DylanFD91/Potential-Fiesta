using System;
using System.Collections.Generic;
using AdditionCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_NegativeNumbers_returnNegativeValues()
        {
            //arrange
            Addition add = new Addition();
            int firstValue = -4;
            int secondValue = -6;
            int expected = -10;
            int actual;
            //act
            actual = add.AddTwoNumbers(firstValue, secondValue);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PositiveNumbersToList_Count()
        {
            //Arrange
            Addition add = new Addition();
            int firstValue = 4;
            int secondValue = 5;
            int expected = 2;
            int actual;
            //Act
            add.AddNumbersToList(firstValue, secondValue);
            actual = add.myNumbers.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PositiveFiveNumbersToList_Count()
        {
            //Arrange
            Addition add = new Addition();
            int expected = 5;
            int actual;
            //Act
            add.AddFiveIntsToList();
            actual = add.myNumbers.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PositiveNumbersToList_FirstIndexValue()
        {
            //Arrange
            Addition add = new Addition();
            int firstValue = 4;
            int secondValue = 5;
            int expected = 4;
            int actual;
            //Act
            add.AddNumbersToList(firstValue, secondValue);
            actual = add.myNumbers[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoPersonObjectToList_FirstIndexValue()
        {
            //Arrange
            Addition add = new Addition();
            Person personOne = new Person() { Name = "Bob", Age = 31 };
            Person personTwo = new Person() { Name = "Frank", Age = 19 };
            string expected = "Bob";
            string actual;
            //Act
            List<Person> ReturnedPeople = add.AddPeople(personOne, personTwo);
            actual = ReturnedPeople[0].Name;
           // actual = add.AddPeople(personOne, personTwo)[0].Name;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
