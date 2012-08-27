using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfServiceServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        private int val;

        //private static object _syn = new object();

        public string GetData(int value)
        {
            //lock (_syn)
            //{
                val = value;
                DateTime start = DateTime.Now;

                Thread.Sleep(1000);

                Thread t = Thread.CurrentThread;

                int treadId = AppDomain.GetCurrentThreadId();

                //return string.Format(value + ": val :  Thread id: {0}", treadId);
            DateTime end = DateTime.Now;
                return string.Format(value + ": val : " + val + " Start: " +start+" End: "+ end+"  Thread id: {0}", treadId);
            //}
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
