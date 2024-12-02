using Castle.DynamicProxy;

namespace StockManagementSystem.Domain.Utilities.Interceptors
{
    public abstract class MethodInterception : IInterceptor
    {
        // metot çağrısından önce
        protected virtual void OnBefore(IInvocation invocation) { }

        // metot çağrısından sonra
        protected virtual void OnAfter(IInvocation invocation) { }

        // hata oluştuğunda
        protected virtual void OnException(IInvocation invocation, Exception e) { }

        // metot başarıyla tamamlandığında
        protected virtual void OnSuccess(IInvocation invocation) { }

        public void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
