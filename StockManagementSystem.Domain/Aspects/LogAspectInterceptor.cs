using Castle.DynamicProxy;
using StockManagementSystem.Domain.Utilities.Interceptors;

namespace StockManagementSystem.Domain.Aspects
{
    public class LogAspectInterceptor : MethodInterception
    {
        private readonly string _logMessage;

        public LogAspectInterceptor(string logMessage)
        {
            _logMessage = logMessage;
        }

        protected override void OnBefore(IInvocation invocation) 
        {
            Console.WriteLine($"[LOG] {_logMessage} - {invocation.Method.Name} cagriliyor.");
        }
    }
}
