using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Core.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int? StockClassId { get; set; }
        public StockClass? StockClass { get; set; }
        public decimal? Quantity { get; set; }
        public string? ShelfInformation { get; set; }
        public string? CabinetInformation { get; set; }
        public int? CriticalQuantity { get; set; }
        public int? StockTypeId { get; set; }
        public StockType? StockType { get; set; }
        public int? StockUnitId { get; set; }
        public StockUnit? StockUnit { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
