using System;
using System.Threading;
using System.Threading.Tasks;


namespace TaskCompletionSource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating TaskCompletionSource");
            TaskCompletionSource<int> tcs1 = new TaskCompletionSource<int>();
            Task<int> t1 = tcs1.Task;

            Console.WriteLine("Starting new thread to set TaskCompletion Result to 5");
            Task.Factory.StartNew(() =>
                                      {
                                          Thread.Sleep(5000);
                                          tcs1.SetResult(5);
                                      });

            Console.WriteLine("Waiting for result,.......");
            var result = t1.Result;
            Console.WriteLine("Result:{0}", result);
            
            Console.WriteLine("Creating new Task that will throw Excepion");

            TaskCompletionSource<int> tcs2 = new TaskCompletionSource<int>();
            Task<int> t2 = tcs2.Task;

            Console.WriteLine("Starting thread that will throw Excepiton after 5secunds");
            Task.Factory.StartNew(() =>
                                      {
                                          Thread.Sleep(1000);
                                          //tcs2.SetException(new Exception("5s exception has elapsed"));
                                          tcs2.SetResult(3);
                                      });

            Console.WriteLine("Witing for Result");
            try
            {
                CancellationToken token = new CancellationToken(false);
                t2.Wait(10000);
                if (t2.Status == TaskStatus.WaitingForActivation)
                {
                    throw new Exception("Maps DataContext Time Out");
                }

                var result2 = t2.Result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }
            Console.WriteLine("Result {0}", t2.Result);
            Console.ReadKey();

        }
    }
}
