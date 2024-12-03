using System;

namespace StockManagementSystem.Domain.Aspects
{
    // bu attribute  loglama işlemleri için kullanılacak unutma
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class LogAspect : Attribute
    {
        public string LogMessage { get; set; }

        public LogAspect(string logMessage)
        {
            LogMessage = logMessage;
        }
    }
}
