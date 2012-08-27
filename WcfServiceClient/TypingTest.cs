using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WcfServiceClient
{
    class TypingTest
    {
        private static void KillComObject(ref object ComObject)
        {
            if (ComObject != null)
            {
                //Ensure the COM object is fully released otherwise future attempts to create will fail
                Marshal.FinalReleaseComObject(ComObject);

                ComObject = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();

                GC.Collect();
            }
        }

    }
}
