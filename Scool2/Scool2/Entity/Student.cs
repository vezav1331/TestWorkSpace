﻿using School.Enums;

namespace School.Entity
{
    /// <summary>
    /// Студенты
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id Студента
        /// </summary>
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
