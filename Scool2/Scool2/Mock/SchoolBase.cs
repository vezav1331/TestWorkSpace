using Scool2.Entity;

namespace Scool2
{
    /// <summary>
    /// 
    /// </summary>
    public class SchoolBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<School> MockMySchool()
        {
            List<School> mySchool = new List<School>();

            mySchool.Add(new School() { Id = 1, SchoolName = "School 1"});
            mySchool.Add(new School() { Id = 2, SchoolName = "School 2" });

            return mySchool;
        }
    }
}
