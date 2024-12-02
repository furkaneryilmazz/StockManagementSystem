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
    public class StockCurrencyUnitManager : IStockCurrencyUnitService
    {
        private readonly IStockCurrencyUnitRepository _stockCurrencyUnitRepository;


        public StockCurrencyUnitManager(IStockCurrencyUnitRepository stockCurrencyUnitRepository)
        {
            _stockCurrencyUnitRepository = stockCurrencyUnitRepository;
        }

        public List<CurrencyUnit> GetAll()
        {
            return _stockCurrencyUnitRepository.GetList();
        }
    }
}
