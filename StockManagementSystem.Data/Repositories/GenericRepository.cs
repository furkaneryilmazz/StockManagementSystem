﻿using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Abstract;
using StockManagementSystem.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        private readonly StockManagementContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(StockManagementContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public T GetById(int id)
        {
            return  _dbSet.Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
