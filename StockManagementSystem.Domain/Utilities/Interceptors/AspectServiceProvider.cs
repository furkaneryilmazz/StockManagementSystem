using Castle.DynamicProxy;
using StockManagementSystem.Domain.Utilities.Interceptors;

namespace StockManagementSystem.Domain.Utilities.Interceptors
{
    public static class AspectServiceProvider
    {
        public static T CreateProxy<T>(T instance) where T : class
        {
            var proxyGenerator = new ProxyGenerator();
            var interceptor = new LoggingInterceptor(); // burada istediğin Interceptor kullan
            return proxyGenerator.CreateInterfaceProxyWithTarget(instance, interceptor);
        }
    }
}
