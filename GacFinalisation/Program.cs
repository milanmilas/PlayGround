using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GacFinalisation
{
    class Program
    {
        static void Main(string[] args)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
