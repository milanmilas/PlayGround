using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;

namespace ThreadingSynchronisationContext
{
    [Synchronization]
    public class AutoLock : ContextBoundObject
    {
        public void Demo()
        {
            Console.WriteLine("Start...");
            Thread.Sleep(1000);
            Console.WriteLine("end");
        }

        public void Test()
        {
            new Thread(Demo).Start();
            new Thread(Demo).Start();
            new Thread(Demo).Start();
            Console.ReadKey();
        }

        public static void Main()
        {
            new AutoLock().Test();
            Console.ReadKey();
        }
    }

}
