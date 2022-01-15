using Scool2.Enums;
using Scool2.Extentions;
using System.Linq;

namespace Scool2
{
    /// <summary>
    /// Главный сервис
    /// </summary>
    public class MainService : IMainService
    {
        /// <summary>
        /// Переменная для обращения к "БД"
        /// </summary>
        private List<MyClass> MyDBContext;

        public void Test()
        {
            MyDBContext = new List<MyClass>();

            var stu = StudentBase.MockStudent();
            var teach = TeacherBase.MockTeacher();
            var kls = MyClassBase.MockUchebnogoClassa();

 
            foreach (var item in kls)
            {
                item.MyTeacher = teach.Where(q => q.MyClassId == item.Id).FirstOrDefault();
                item.MyListStudents = stu.Where(w => w.MyClassId == item.Id).ToList();

                MyDBContext.Add(item);
            }
            var ppp = 333;
        }

        public void Query1()
        {
            var rezult = MyDBContext.Select(a => a.ToMyClassWithStudentsAndTeachers()).ToList();

            var rezult1_1 = MyDBContext.Select(q => new
            {
                test1 = q.ClassName,
                test2 = q.MyListStudents.Select(w => w.Name).ToList(),
                test3 = q.MyTeacher.Name
            }).ToList();

            var a = 333;
        }

        public void Query2()
        {
            var rezult2 = MyDBContext.Where(b => b.Id == 2 || b.Id == 4).Select(ww => ww.ToMyStudents()).ToList();
            var b = 333;
        }

        //3. Есть ли хоть 1 студент из 5 класса
        public void Query3()
        {
            
            var rezult3 = MyDBContext.Any(b => b.Id == 2);
            var b = 333;
        }

        //4. Добавить студентам уникальное поле.Хобби.Сделать выборку по массиву студентов
        //которые занимаются Плаванием, рисованием и стрельбой
        public void Query4()
        {
            var rezu4 = MyDBContext.SelectMany(q => q.MyListStudents
                .Where(w => w.Hobby
                    .Any(e => e == HobbyListEnum.Sport)))
                .ToList();

            var b = 333;
        }

        //5. Выборка по всем классам. вывести средний бал всех оценок в класее
        public void Query5()
        {
            //var rezult5 = MyDBContext.SelectMany(q => q.MyListStudents.Where(w => w.MyClassId == 2)).ToList();
            var rezult5 = MyDBContext.SelectMany(q => q.MyListStudents.Where(w => w.MyClassId == 2)).Average(n => n.MediumBall);

            var b = 1;
        }
        //6. Добавляешь ещё список классов(другая школа). Выводишь на экран через Linq учеников всех классов двух школ



    }
}
