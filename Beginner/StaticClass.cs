using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    static class StaticClass
    {
        /*can not declare a instance method in static class ,so can create static method in static class*/
        public static void Today(string date)
        {
            Console.WriteLine("Today is " + date);
        }
    }
}
