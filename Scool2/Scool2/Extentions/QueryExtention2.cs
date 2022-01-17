using School.Entity;
using School.Models;

namespace School.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryExtention2
    {
        /// <summary>
        /// Мапер2
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
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
