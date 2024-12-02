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
            _stockRepository.Add(stock);
        }

        public void Delete(int id)
        {
            var stock = GetById(id);
            if(stock != null)
            {
                _stockRepository.Delete(stock);
            }
        }

        public List<Stock> GetAll()
        {
            return _stockRepository.GetList();
        }

        public List<Stock> GetAllIncludingStock()
        {
            return _stockRepository.GetList();
        }

        public Stock GetById(int id)
        {
            return _stockRepository.Get(x => x.Id == id);
        }

        public void Update(Stock stock)
        {
            _stockRepository.Update(stock);
        }
    }
}
