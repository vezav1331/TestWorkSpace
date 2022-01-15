using Scool2.Enums;

namespace Scool2
{
    /// <summary>
    /// Студенты
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        /// <summary>
        /// ФИО Студента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MyClassId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<HobbyListEnum> Hobby { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MediumBall { get; set; }
    }
}
