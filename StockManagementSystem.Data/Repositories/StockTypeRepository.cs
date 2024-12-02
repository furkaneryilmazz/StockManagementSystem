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
    public class StockTypeRepository : GenericRepository<StockType>, IStockTypeRepository
    {
        private readonly StockManagementContext _context;
        public StockTypeRepository(StockManagementContext context) : base(context)
        {
        }

        public StockType GetByName(string name)
        {
            return _context.StockTypes.FirstOrDefault(x => x.StockTypeName == name);
        }
    }
}
