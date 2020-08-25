using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace CustomListMethodTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TwoValues_CountOf2()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int expected = 2;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FourValues_CountOf4()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 10;
            int expected = 4;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoValues_CountOf10()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int expected = 10;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
