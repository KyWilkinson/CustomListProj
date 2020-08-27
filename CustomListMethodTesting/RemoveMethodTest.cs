using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Security.Cryptography.X509Certificates;

namespace CustomListMethodTesting
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void Remove_OneValue_CountOf1()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int expected = 1;
            int actual;
            customList.Add(value1);
            customList.Add(value2);

            //Act
            customList.Remove(2);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValue_CountOf3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int expected = 3;
            int actual;
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);

            //Act
            customList.Remove(2);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FourValues_CountOf0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int expected = 0;
            int actual;
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);

            //Act
            customList.Remove(2);
            customList.Remove(4);
            customList.Remove(6);
            customList.Remove(8);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_TwoValues_CountOf0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int expected = 0;
            int actual;
            customList.Add(value1);
            customList.Add(value2);

            //Act
            customList.Remove(2);
            customList.Remove(4);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FourValues_CountOf6()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 10;
            int value5 = 15;
            int value6 = 35;
            int value7 = 50;
            int value8 = 65;
            int value9 = 80;
            int value10 = 100;
            int expected = 6;
            int actual;
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Add(value10);

            //Act
            customList.Remove(2);
            customList.Remove(4);
            customList.Remove(50);
            customList.Remove(80);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Display_Array_Index()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int value1 = 2;
        //    int value2 = 4;
        //    int value3 = 6;
        //    int value4 = 8;
        //    customList.Add(value1);
        //    customList.Add(value2);
        //    customList.Add(value3);
        //    customList.Add(value4);
        //    int expected = 8;
        //    int actual;
        //    //Act
        //    customList.Remove(value3);
        //    actual = customList[2];
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void Remove_OneValue_OfMultipleEqualValue()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int expected = 3;
            int actual;
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value1);
            customList.Add(value2);

            //Act
            customList.Remove(2);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
