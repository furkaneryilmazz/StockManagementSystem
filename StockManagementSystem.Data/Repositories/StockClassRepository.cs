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
    public class StockClassRepository : GenericRepository<StockClass>, IStockClassRepository
    {
        private readonly StockManagementContext _context;
        public StockClassRepository(StockManagementContext context) : base(context)
        {
        }

        public List<StockClass> GetAll()
        {
            return _context?.StockClasses.ToList();
        }
    }
}
