using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Domain.Aspects
{
    public class StockUnitManager
    {
        [LogAspect("Stok birimi ekleme islemi baslatildi.")]
        public void Add()
        {
            Console.WriteLine("Stok birimi eklendi.");
        }

        [LogAspect("Stok birimi ekleme islemi baslatildi.")]
        public void Update()
        {
            Console.WriteLine("Stok birimi güncellendi.");
        }
    }
}
