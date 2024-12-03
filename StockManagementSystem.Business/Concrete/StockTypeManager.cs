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
    public class StockTypeManager : IStockTypeService
    {
        private readonly IStockTypeRepository _stockTypeRepository;

        public StockTypeManager(IStockTypeRepository stockTypeRepository)
        {
            _stockTypeRepository = stockTypeRepository;
        }

        public void Add(StockType stockType)
        {
            try
            {
                _stockTypeRepository.Add(stockType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türü ekleme işlemi sırasında bir hata oluştu.");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var stockType = _stockTypeRepository.Get(st => st.Id == id);
                if (stockType == null)
                {
                    throw new Exception("Silinecek stok türü bulunamadı.");
                }
                _stockTypeRepository.Delete(stockType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türü silme işlemi sırasında bir hata oluştu.");
            }
        }

        public List<StockType> GetAll()
        {
            try
            {
                return _stockTypeRepository.GetList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türleri listeleme işlemi sırasında bir hata oluştu.");
            }
        }

        public StockType GetById(int id)
        {
            try
            {
                return _stockTypeRepository.Get(st => st.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türü getirme işlemi sırasında bir hata oluştu.");
            }
        }

        public StockType GetByName(string name)
        {
            try
            {
                return _stockTypeRepository.GetByName(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türünun ismini getirme işlemi sırasında bir hata oluştu.");
            }
        }

        public void Update(StockType stockType)
        {
            try
            {
                _stockTypeRepository.Update(stockType);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok türü güncelleme işlemi sırasında bir hata oluştu.");
            }
        }
    }
}
