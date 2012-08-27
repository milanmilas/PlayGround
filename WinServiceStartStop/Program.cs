using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Threading.Timer;

namespace WinServiceStartStop
{
    class Program
    {
        static EventWaitHandle _waitHandle = new AutoResetEvent(false);
        static string user = "maxadmin";
        static string password = "maxadmin";
        static string domain = "LON-DEV-MIMI";

        static void Main(string[] args)
        {
            //string con = "Data Source=localhost; Initial Catalog=NHSDEMO; User Id=sa; Password=seaward;Application Name=Magnum;";
            //var serv = new ServiceReference1.FinalisationServiceClient("BasicHttpBinding_FinalisationService");

            //new ThreadStaticAttribute()


            int resetTimeLimit = 30;
            int resetCheckStatus = 1;

            var serCont = new ServiceController();
            serCont.ServiceName = "MSSQLSERVER";
            serCont.MachineName = "LON-DEV-MIMI";

            if (serCont.Status != ServiceControllerStatus.Stopped)
            {
                try
                {
                    CallWithImpersonation(serCont.Stop, user, password, domain);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Timer startTimer = new System.Threading.Timer(TryStartService, serCont, 0, 1000);

            _waitHandle.WaitOne(30000);

            startTimer.Dispose();


        }

        private static void CallWithImpersonation(Action action, string user, string password, string domain)
        {
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(domain))
            {
                using (new Impersonator(user, password, domain))
                {
                    action();
                }
            }
            else
            {
                action();
            }
        }

        public static void TryStartService(object serContpar)
        {
            var serCont = (ServiceController)serContpar;

            if (serCont.Status == ServiceControllerStatus.Stopped)
            {
                try
                {
                    CallWithImpersonation(serCont.Stop, user, password, domain);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    _waitHandle.Set();
                }
            }
        }
    }
}
