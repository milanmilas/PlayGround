// Type: System.Web.Mvc.HandleErrorAttribute
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\Program Files\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

using System;

namespace System.Web.Mvc
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class HandleErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public Type ExceptionType { get; set; }
        public string Master { get; set; }
        public override object TypeId { get; }
        public string View { get; set; }

        #region IExceptionFilter Members

        public virtual void OnException(ExceptionContext filterContext);

        #endregion
    }
}
