﻿using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface IStockQuantityUnitService
    {
        List<StockQuantityUnit> GetAll();
    }
}
