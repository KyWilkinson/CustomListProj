using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value3);
            customList.Remove(value3);
            //customList[0];
            Console.ReadLine();
            


            //CustomList<int> test = new CustomList<int>() { 1, 2, 3 }; needs an add method and ienumerbale 
        }
    }
}
