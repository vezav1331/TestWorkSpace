using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2
{
    public class MyClassBase2
    {
        public static List<MyClass2> MockUchebnogoClassa2()
        {
            List<MyClass2> myClass2 = new List<MyClass2>();

            myClass2.Add(new MyClass2() { Id = 1, ClassName = "Класс1_Школа2" });
            myClass2.Add(new MyClass2() { Id = 2, ClassName = "Класс2_Школа2" });
            myClass2.Add(new MyClass2() { Id = 3, ClassName = "Класс3_Школа2" });
            myClass2.Add(new MyClass2() { Id = 4, ClassName = "Класс4_Школа2" });

            return myClass2;
        }
    }
}
