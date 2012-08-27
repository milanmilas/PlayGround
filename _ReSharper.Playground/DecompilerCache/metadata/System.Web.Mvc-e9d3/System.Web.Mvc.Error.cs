// Type: System.Web.Mvc.Error
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\Program Files\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

using System;
using System.Web.Mvc.Async;

namespace System.Web.Mvc
{
    internal static class Error
    {
        public static InvalidOperationException AsyncActionMethodSelector_CouldNotFindMethod(string methodName,
                                                                                             Type controllerType);

        public static InvalidOperationException AsyncCommon_AsyncResultAlreadyConsumed();

        public static InvalidOperationException AsyncCommon_ControllerMustImplementIAsyncManagerContainer(
            Type actualControllerType);

        public static ArgumentException AsyncCommon_InvalidAsyncResult(string parameterName);
        public static ArgumentOutOfRangeException AsyncCommon_InvalidTimeout(string parameterName);

        public static InvalidOperationException ReflectedAsyncActionDescriptor_CannotExecuteSynchronously(
            string actionName);

        public static InvalidOperationException ChildActionOnlyAttribute_MustBeInChildRequest(
            ActionDescriptor actionDescriptor);

        public static ArgumentException ParameterCannotBeNullOrEmpty(string parameterName);
        public static InvalidOperationException PropertyCannotBeNullOrEmpty(string propertyName);
        public static SynchronousOperationException SynchronizationContextUtil_ExceptionThrown(Exception innerException);
        public static InvalidOperationException ViewDataDictionary_WrongTModelType(Type valueType, Type modelType);
        public static InvalidOperationException ViewDataDictionary_ModelCannotBeNull(Type modelType);
    }
}
