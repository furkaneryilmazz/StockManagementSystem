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
    public class StockQuantityUnitRepository : GenericRepository<StockQuantityUnit>, IStockQuantityUnitRepository
    {
        private readonly StockManagementContext _context;

        public StockQuantityUnitRepository(StockManagementContext context) : base(context)
        {
        }

        public List<StockQuantityUnit> GetAll()
        {
            return _context?.StockQuantityUnits.ToList();
        }
    }
}
