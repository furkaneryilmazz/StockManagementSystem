﻿using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface IStockTypeService
    {
        List<StockType> GetAll();
        StockType GetById(int id);
        void Add(StockType stockType);
        void Update(StockType stockType);
        void Delete(int id);

        StockType GetByName(string name);
    }
}