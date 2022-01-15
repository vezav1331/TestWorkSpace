using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2
{
    public class MyClassBase
    {
        public static List<MyClass> MockUchebnogoClassa()
        {
            List<MyClass> myClass = new List<MyClass>();

            myClass.Add(new MyClass() { Id = 1, ClassName = "Класс1", SchoolId = 1 });
            myClass.Add(new MyClass() { Id = 2, ClassName = "Класс2", SchoolId = 1 });
            myClass.Add(new MyClass() { Id = 3, ClassName = "Класс3", SchoolId = 2 });
            myClass.Add(new MyClass() { Id = 4, ClassName = "Класс4", SchoolId = 2 });

            return myClass;
        }
    }
}
