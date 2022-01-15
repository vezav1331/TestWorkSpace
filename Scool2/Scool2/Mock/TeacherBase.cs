namespace Scool2
{
    /// <summary>
    /// 
    /// </summary>
    public class TeacherBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Teacher> MockTeacher()
        {
            List<Teacher> teatcers = new List<Teacher>();

            teatcers.Add(new Teacher() { Id = 1, Name = "Марья Ивановна_____", MyClassId = 1} );
            teatcers.Add(new Teacher() { Id = 2, Name = "Василиса Прекрасная", MyClassId = 2 });
            teatcers.Add(new Teacher() { Id = 3, Name = "Баба Яга___________", MyClassId = 3 });
            teatcers.Add(new Teacher() { Id = 4, Name = "Вержак", MyClassId = 4 });

            return teatcers;
        }
    }
}
