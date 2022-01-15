using Scool2.Models;

namespace Scool2.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueryEcxtetion2
    {
        /// <summary>
        /// 
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
