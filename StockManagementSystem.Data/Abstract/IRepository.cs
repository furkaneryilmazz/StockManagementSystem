﻿using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T GetById(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
