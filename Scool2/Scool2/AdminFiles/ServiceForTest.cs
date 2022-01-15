using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.AdminFiles
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceForTest : IServiceForTest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public List<int> TestMethod1(int param1, int param2)
        {
            var result = new List<int>();

            //Тест 1
            if (param1 >= 10)
            {
                result.Add(10 * 10);
            }

            //Тест 2
            if (param2 <= 10)
            {
                result.Add(-10 * 10);
            }

            return result;
        }

    }
}
