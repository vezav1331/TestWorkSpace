using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2.Entity
{
    public class School
    {
        public int Id { get; set; }

        public string SchoolName { get; set; }

        public List<MyClass> MyClasses { get; set; }
    }
}
