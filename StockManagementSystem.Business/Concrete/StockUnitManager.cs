using Microsoft.Extensions.Logging;
//using StockManagementSystem.Aspects;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Abstract;
using StockManagementSystem.Domain.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Concrete
{
    public class StockUnitManager : IStockUnitService
    {
        private readonly IStockUnitRepository _stockUnitRepository;

        public StockUnitManager()
        {
        }

        public StockUnitManager(IStockUnitRepository stockUnitRepository)
        {
            _stockUnitRepository = stockUnitRepository ?? throw new ArgumentNullException(nameof(stockUnitRepository));
        }


        [LogAspect("Stok birimi ekleme işlemi başladı.")]
        public void Add(StockUnit stockUnit)
        {
            try
            {
                _stockUnitRepository.Add(stockUnit);
                Console.WriteLine("Stok Birimi eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimi ekleme işlemi sırasında bir hata oluştu.");
            }

        }

        public void Delete(int id)
        {
            try
            {
                _stockUnitRepository.Delete(GetById(id));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimi silme işlemi sırasında bir hata oluştu.");
            }
        }

        public List<StockUnit> GetAll()
        {
            try
            {
                Console.WriteLine("Stok Birimi listelendi.");
                return _stockUnitRepository.GetList();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimleri alınırken bir hata oluştu.");
            }
        }

        public List<StockUnit> GetAllIncludingStockQuantityType()
        {
            try
            {
                return _stockUnitRepository.GetAllIncludingStockQuantityType();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimlerini stok miktarları ile alınırken bir hata oluştu.");
            }
        }

        public List<StockUnit> GetAllIncludingStockType()
        {
            try
            {
                return _stockUnitRepository.GetAllIncludingStockType();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimlerini stok tipleri ile alınırken bir hata oluştu.");
            }
        }

        public StockUnit GetById(int id)
        {
            try
            {
                return _stockUnitRepository.Get(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimi alınırken bir hata oluştu.");
            }
        }

        [LogAspect("Stok birimi güncelleme işlemi başladı.")]
        public void Update(StockUnit stockUnit)
        {
            try
            {
                _stockUnitRepository.Update(stockUnit);
                Console.WriteLine("Stok Birimi güncellendi.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw new Exception("Stok birimi güncelleme işlemi sırasında bir hata oluştu.");
            }
        }
    }
}
