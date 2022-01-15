using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scool2
{
    public class Program
    {
 
        public static void Main()
        {
            IMainService service = new MainService();

            service.Test();

            service.Query1();

            service.Query2();

            service.Query3();

            service.Query4();

            service.Query5();

            /*

            MainService.Studi(stu);
            MainService.Uchilki(teach);
            MainService.Klassi(kls);

            MainService.Sborka(stu, teach, kls);
            */
        }

    }
}

