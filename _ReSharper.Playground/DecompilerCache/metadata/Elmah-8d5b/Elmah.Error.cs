// Type: Elmah.Error
// Assembly: Elmah, Version=1.2.14706.0, Culture=neutral
// Assembly location: C:\Users\Admin\Dropbox\Documents\Programming\Projects\Playground\packages\elmah.corelibrary.1.2.2\lib\Elmah.dll

using System;
using System.Collections.Specialized;
using System.Web;

namespace Elmah
{
    [Serializable]
    public sealed class Error : ICloneable
    {
        public Error();
        public Error(Exception e);
        public Error(Exception e, HttpContext context);
        public Exception Exception { get; }
        public string ApplicationName { get; set; }
        public string HostName { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public string User { get; set; }
        public DateTime Time { get; set; }
        public int StatusCode { get; set; }
        public string WebHostHtmlMessage { get; set; }
        public NameValueCollection ServerVariables { get; }
        public NameValueCollection QueryString { get; }
        public NameValueCollection Form { get; }
        public NameValueCollection Cookies { get; }

        #region ICloneable Members

        object ICloneable.Clone();

        #endregion

        public override string ToString();
    }
}
