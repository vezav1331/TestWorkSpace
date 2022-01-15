using Scool2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2
{
    public class SchoolBase
    {
        public static List<School> MockMySchool()
        {
            List<School> mySchool = new List<School>();

            mySchool.Add(new School() { Id = 1, SchoolName = "School 1"});
            mySchool.Add(new School() { Id = 2, SchoolName = "School 2" });

            return mySchool;
        }
    }
}
