using Castle.DynamicProxy;

namespace StockManagementSystem.Domain.Utilities.Interceptors
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            // metot çağrılmadan önce
            Console.WriteLine($"[LOG] {invocation.Method.Name} metodu cagrilacak.");

            try
            {
                invocation.Proceed(); // asıl metodu çalıştır
            }
            catch (Exception ex)
            {
                // hata durumunda
                Console.WriteLine($"[ERROR] {invocation.Method.Name}: {ex.Message}");
                throw;
            }

            // metot başarıyla çalıştıktan sonra
            Console.WriteLine($"[LOG] {invocation.Method.Name} metodu basariyla tamamlandi.");
        }
    }
}
