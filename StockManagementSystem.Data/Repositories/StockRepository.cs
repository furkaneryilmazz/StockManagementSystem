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
    public class StockRepository : GenericRepository<Stock>, IStockRepository
    {
        private readonly StockManagementContext _context;
        public StockRepository(StockManagementContext context) : base(context)
        {
        }

        public List<Stock> GetAllIncludingStock()
        {
            return _context?.Stocks.Include(x=> x.StockClass).ToList();
        }
    }
}
