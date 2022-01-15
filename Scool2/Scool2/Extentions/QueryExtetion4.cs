using Scool2.Models;

namespace Scool2.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryExtetion4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myClass"></param>
        /// <returns></returns>
        public static StudentsHobby ToStudentsHobby(this MyClass myClass)
        {
            return new StudentsHobby()
            {
                NameStudents = myClass.MyListStudents.Select(w => w.Name).ToList(),
            };
        }
    }
}
