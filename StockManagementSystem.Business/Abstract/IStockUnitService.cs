using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface IStockUnitService
    {
        List<StockUnit> GetAll();
        List<StockUnit> GetAllIncludingStockType();
        List<StockUnit> GetAllIncludingStockQuantityType();
        StockUnit GetById(int id);
        void Add(StockUnit stockUnit);
        void Update(StockUnit stockUnit);
        void Delete(int id);
    }
}
