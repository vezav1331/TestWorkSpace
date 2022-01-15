using Scool2.Enums;

namespace Scool2
{
    /// <summary>
    /// Студенты
    /// </summary>
    public class Student2
    {
        public int Id { get; set; }

        /// <summary>
        /// ФИО Студента
        /// </summary>
        public string Name { get; set; }

        public int MyClassId { get; set; }

        public List<HobbyListEnum> Hobby { get; set; }

        public int MediumBall { get; set; }
    }
}
