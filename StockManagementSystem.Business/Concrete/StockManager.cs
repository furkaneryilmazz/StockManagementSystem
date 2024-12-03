using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IRepository<Stock> _stockRepository;


        public StockManager(IRepository<Stock> stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public void Add(Stock stock)
        {
            try
            {
                _stockRepository.Add(stock);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok ekleme islemi sirasinda bir hata olustu.");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var stock = GetById(id);
                if (stock != null)
                {
                    _stockRepository.Delete(stock);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok silme islemi sirasinda bir hata olustu.");
            }

        }

        public List<Stock> GetAll()
        {
            try
            {
                return _stockRepository.GetList();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stoklar alınırken bir hata oluştu.");
            }
        }

        public List<Stock> GetAllIncludingStock()
        {
            return _stockRepository.GetList();
        }

        public Stock GetById(int id)
        {
            try
            {
                return _stockRepository.Get(x => x.Id == id);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok alınırken bir hata oluştu.");
            }

        }

        public void Update(Stock stock)
        {
            try
            {
                _stockRepository.Update(stock);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok guncelleme islemi sirasinda bir hata olustu.");
            }
        }
    }
}
