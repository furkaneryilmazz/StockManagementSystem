using System;

namespace StockManagementSystem.Aspects
{
    // Attribute: Loglama için kullanılacak
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class LogAspect : Attribute
    {
        public string LogMessage { get; set; } // Log mesajı

        public LogAspect(string logMessage)
        {
            LogMessage = logMessage; // Kullanıcı tarafından girilen mesaj atanır
        }
    }
}
