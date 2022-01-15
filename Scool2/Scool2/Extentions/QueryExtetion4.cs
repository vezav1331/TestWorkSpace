using Scool2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2.Extentions
{
    public static class QueryExtetion4
    {
        public static StudentsHobby ToStudentsHobby(this MyClass myClass)
        {
            return new StudentsHobby()
            {
                NameStudents = myClass.MyListStudents.Select(w => w.Name).ToList(),
            };
        }
    }
}
