namespace Scool2
{
    /// <summary>
    /// Учебные классы
    /// </summary>
    public class MyClass2
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя класса
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Список студентов класса
        /// </summary>
        public List<Student> MyListStudents { get; set; }

        /// <summary>
        /// Учитель класса
        /// </summary>
        public Teacher MyTeacher { get; set; }
    }
}
