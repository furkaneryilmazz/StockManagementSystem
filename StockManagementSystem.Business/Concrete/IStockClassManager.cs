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
    public class IStockClassManager : IStockClassService
    {
        private readonly IStockClassRepository _stockClassRepository;

        public IStockClassManager(IStockClassRepository stockClassRepository)
        {
            _stockClassRepository = stockClassRepository;
        }

        public List<StockClass> GetAll()
        {
            return _stockClassRepository.GetList();
        }
    }
}
