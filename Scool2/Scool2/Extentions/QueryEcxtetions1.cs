using Scool2.Models;

namespace Scool2.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryEcxtetions1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
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
