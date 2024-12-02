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
            _stockUnitRepository.Add(stockUnit);
            Console.WriteLine("Stok Birimi eklendi.");
        }

        public void Delete(int id)
        {
           _stockUnitRepository.Delete(GetById(id));
        }

        public List<StockUnit> GetAll()
        {
            return _stockUnitRepository.GetList();
        }

        public List<StockUnit> GetAllIncludingStockQuantityType()
        {
            return _stockUnitRepository.GetAllIncludingStockQuantityType();
        }

        public List<StockUnit> GetAllIncludingStockType()
        {
            return _stockUnitRepository.GetAllIncludingStockType();
        }

        public StockUnit GetById(int id)
        {
            return _stockUnitRepository.Get(x => x.Id == id);
        }

        public void Update(StockUnit stockUnit)
        {
            _stockUnitRepository.Update(stockUnit);
        }
    }
}
