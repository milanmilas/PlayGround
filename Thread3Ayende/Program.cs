using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread3Ayende
{
    public class Strange { [ThreadStatic]    public /* static */ int Value;}

    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Strange {Value = 1};
            var s2 = new Strange { Value = 2 };
            Console.WriteLine(s1.Value);
            Console.WriteLine(s2.Value);
            ThreadPool.QueueUserWorkItem(
                state =>{    Console.WriteLine(s1.Value);    Console.WriteLine(s2.Value);});
            Console.ReadKey();
        }
    }
}
