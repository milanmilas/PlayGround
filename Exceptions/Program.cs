using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Exception e = new Exception("Exception 1");
                    throw e;

                }
                catch (Exception ex2)
                {
                    Exception n = new Exception("Exception 2", ex2);
                    throw n;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}
