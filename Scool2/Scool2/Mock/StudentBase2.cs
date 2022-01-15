using Scool2.Enums;
using System.Linq;

namespace Scool2
{
    public class StudentBase2
    {
          public static List<Student2> MockStudent2()
          {
            List<Student2> students2 = new List<Student2>();

            students2.Add(new Student2() { Id = 1, Name= "Иванов___шк2", MyClassId = 1, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Swim, HobbyListEnum.Sport}, MediumBall= 3 });
            students2.Add(new Student2() { Id = 2, Name = "Петров___шк2", MyClassId = 1, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Art }, MediumBall = 5 });
            students2.Add(new Student2() { Id = 3, Name = "Йцукен___шк2", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Sport }, MediumBall =5 });
            students2.Add(new Student2() { Id = 4, Name = "Кулибаба_шк2", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Drow }, MediumBall = 5 });
            students2.Add(new Student2() { Id = 5, Name = "Козладой_шк2", MyClassId = 2, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Drow }, MediumBall = 2 });
            students2.Add(new Student2() { Id = 6, Name = "Морозкин_шк2", MyClassId = 3, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Art }, MediumBall = 5 });
            students2.Add(new Student2() { Id = 7, Name = "Пупкин___шк2", MyClassId = 4, Hobby = new List<HobbyListEnum>() { HobbyListEnum.Swim }, MediumBall =1 });

            return students2;
        }
    }
}
