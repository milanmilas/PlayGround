using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient.ServiceReference1;

namespace WcfServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new Service1Client();

            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            Parallel.ForEach(numbers, i => Console.WriteLine(new Service1Client().GetData(i)));


            Console.ReadKey();
        }
    }
}
