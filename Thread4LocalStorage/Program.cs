using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread4LocalStorage
{
    class Program
    {
        public static void WriteError()
        {
            Console.WriteLine("Error number = " + Thread.GetData(Thread.GetNamedDataSlot("ErrNo")));
            Console.WriteLine("Error source = " + Thread.GetData(Thread.GetNamedDataSlot("ErrSource")));
        }

        // the SetError method sets a random error number
        public static void SetError()
        {
            Random r = new Random();
            Thread.SetData(Thread.GetNamedDataSlot("ErrNo"), r.Next(100));
            Thread.SetData(Thread.GetNamedDataSlot("ErrSource"), Thread.CurrentThread.Name);
            WriteError();
        }

        public static void Main()
        {
            // allocate some named data slots
            Thread.AllocateNamedDataSlot("ErrNo");
            Thread.AllocateNamedDataSlot("ErrSource");

            // create and start a second thread
            Thread t2 = new Thread(new ThreadStart(SetError));
            t2.Name = "t2";
            t2.Start();

            // create a third thread
            Thread t3 = new Thread(new ThreadStart(SetError));
            t3.Name = "t3";
            t3.Start();

            // clean up the data slots
            Thread.FreeNamedDataSlot("ErrNo");
            Thread.FreeNamedDataSlot("ErrSource");

            Console.ReadKey();

        }

    }
}
