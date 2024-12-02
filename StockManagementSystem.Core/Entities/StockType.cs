using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Core.Entities
{
    public class StockType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen stok türünü giriniz.")]
        public string? StockTypeName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
