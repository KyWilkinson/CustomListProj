using System;
using CustomListProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListMethodTesting
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void Display_Ints_ConvertToString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 2, 4, 6 };
            string expected = "246";
            string actual;
            //Act
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Display_String_ConvertToString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "2", "4", "6" };
            string expected = "246";
            string actual;
            //Act
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Display_EmptyList_ConvertToString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = null;
            int actual;
            //Act
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
