using Scool2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2.Extentions
{
    public static class QueryEcxtetions1
    {
        public static MyClassWithStudentsAndTeachers ToMyClassWithStudentsAndTeachers(this MyClass myClass)
        {
            return new MyClassWithStudentsAndTeachers() 
            {
                ClassName = myClass.ClassName,
                NameStudents = myClass.MyListStudents.Select(w => w.Name).ToList(), 
                NameTeacher = myClass.MyTeacher.Name
            };
        }
    }
}
