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
    public class StockQuantityUnitManager : IStockQuantityUnitService
    {
        private readonly IStockQuantityUnitRepository _stockQuantityUnitRepository;

        public StockQuantityUnitManager(IStockQuantityUnitRepository stockQuantityUnitRepository)
        {
            _stockQuantityUnitRepository = stockQuantityUnitRepository;
        }

        public List<StockQuantityUnit> GetAll()
        {
            return _stockQuantityUnitRepository.GetList();
        }
    }
}
