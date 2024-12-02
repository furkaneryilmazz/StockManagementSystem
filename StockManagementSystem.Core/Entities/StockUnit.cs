using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Core.Entities
{
    public class StockUnit
    {
        public int Id { get; set; }
        public string? StockUnitCode { get; set; }
        public int? StockTypeId { get; set; }
        public StockType? StockType { get; set; }
        public int? StockQuantityUnitId { get; set; }
        public StockQuantityUnit? StockQuantity { get; set; }
        public string? Description { get; set; }
        public int? BuyingPrice { get; set; }
        public int? CurrencyUnitId { get; set; }
        public CurrencyUnit? CurrencyUnit { get; set; }
        public int? SalePrice { get; set; }
        public int? PaperWeight { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
