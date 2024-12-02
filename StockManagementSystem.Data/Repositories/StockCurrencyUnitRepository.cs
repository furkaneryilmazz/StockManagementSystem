using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Abstract;
using StockManagementSystem.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data.Repositories
{
    public class StockCurrencyUnitRepository : GenericRepository<CurrencyUnit>, IStockCurrencyUnitRepository
    {
        private readonly StockManagementContext _context;
        public StockCurrencyUnitRepository(StockManagementContext context) : base(context)
        {
        }
    }
}
