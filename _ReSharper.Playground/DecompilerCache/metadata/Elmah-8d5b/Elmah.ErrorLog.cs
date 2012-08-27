// Type: Elmah.ErrorLog
// Assembly: Elmah, Version=1.2.14706.0, Culture=neutral
// Assembly location: C:\Users\Admin\Dropbox\Documents\Programming\Projects\Playground\packages\elmah.corelibrary.1.2.2\lib\Elmah.dll

using System;
using System.Collections;
using System.Web;

namespace Elmah
{
    public abstract class ErrorLog
    {
        protected ErrorLog();
        public virtual string Name { get; }
        public string ApplicationName { get; set; }

        [Obsolete("Use ErrorLog.GetDefault(context) instead.")]
        public static ErrorLog Default { get; }

        public abstract string Log(Error error);
        public virtual IAsyncResult BeginLog(Error error, AsyncCallback asyncCallback, object asyncState);
        public virtual string EndLog(IAsyncResult asyncResult);
        public abstract ErrorLogEntry GetError(string id);
        public virtual IAsyncResult BeginGetError(string id, AsyncCallback asyncCallback, object asyncState);
        public virtual ErrorLogEntry EndGetError(IAsyncResult asyncResult);
        public abstract int GetErrors(int pageIndex, int pageSize, IList errorEntryList);

        public virtual IAsyncResult BeginGetErrors(int pageIndex, int pageSize, IList errorEntryList,
                                                   AsyncCallback asyncCallback, object asyncState);

        public virtual int EndGetErrors(IAsyncResult asyncResult);
        public static ErrorLog GetDefault(HttpContext context);
    }
}
