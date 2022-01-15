using Scool2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2.Extentions
{
    public static class QueryEcxtetion2
    {
        public static MyClassStudents ToMyStudents(this MyClass myClass)
        {
            return new MyClassStudents()
            {
                NameStudents = myClass.MyListStudents.Select(w => w.Name).ToList(),
                ClassId = myClass.Id
            };
        }
    }
}
