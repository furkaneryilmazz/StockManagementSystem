using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data.Abstract
{
    public interface IStockUnitRepository : IRepository<StockUnit>
    {
        List<StockUnit> GetAllIncludingStockType();
        List<StockUnit> GetAllIncludingStockQuantityType();
    }
}
