using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace WinServiceStartStop
{
    public class Impersonator : IDisposable
    {
        #region Interop imports/constants
        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_LOGON_SERVICE = 3;
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool LogonUser(String lpszUserName, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);
        #endregion

        private WindowsImpersonationContext _impersonatedUser = null;
        private IntPtr _userHandle;
        public Impersonator(String user, String password, string userDomain)
        {
            _userHandle = new IntPtr(0);
            bool returnValue = LogonUser(user, userDomain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref _userHandle);
            if (!returnValue)
                throw new ApplicationException("Could not impersonate user");
            WindowsIdentity newId = new WindowsIdentity(_userHandle);
            _impersonatedUser = newId.Impersonate();
        }
        #region IDisposable Members

        public void Dispose()
        {
            if (_impersonatedUser != null)
            {
                _impersonatedUser.Undo();
                CloseHandle(_userHandle);
            }
        }
        #endregion
    }
}
