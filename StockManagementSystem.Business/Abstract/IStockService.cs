using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAllIncludingStock();
        List<Stock> GetAll();
        Stock GetById(int id);
        void Add(Stock stock);  
        void Update(Stock stock);
        void Delete(int id);
    }
}
