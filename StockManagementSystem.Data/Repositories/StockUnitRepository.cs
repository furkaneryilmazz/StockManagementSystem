using Microsoft.EntityFrameworkCore;
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
    public class StockUnitRepository : GenericRepository<StockUnit>,IStockUnitRepository
    {
        private readonly StockManagementContext _context;

        public StockUnitRepository(StockManagementContext context) : base(context)
        {
        }

        public List<StockUnit> GetAllIncludingStockQuantityType()
        {
            return _context?.StockUnits.Include(x => x.StockQuantity).ToList();
        }

        public List<StockUnit> GetAllIncludingStockType()
        {
            return _context?.StockUnits.Include(x => x.StockType).ToList();
        }
    }
}
