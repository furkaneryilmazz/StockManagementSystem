using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Concrete
{
    public class StockTypeManager : IStockTypeService
    {
        private readonly IStockTypeRepository _stockTypeRepository;

        public StockTypeManager(IStockTypeRepository stockTypeRepository)
        {
            _stockTypeRepository = stockTypeRepository;
        }

        public void Add(StockType stockType)
        {
            //if(_stockTypeRepository.GetByName(stockType.Name) != null)
            //{
            //    throw new Exception("Bu isimde bir stok türü zaten mevcut.");
            //}
            _stockTypeRepository.Add(stockType);
        }

        public void Delete(int id)
        {
            var stockType = _stockTypeRepository.Get(st => st.Id == id);
            if(stockType == null)
            {
                throw new Exception("Silinecek stok türü bulunamadı.");
            }
            _stockTypeRepository.Delete(stockType);
        }

        public List<StockType> GetAll()
        {
            return _stockTypeRepository.GetList();
        }

        public StockType GetById(int id)
        {
            return _stockTypeRepository.Get(st => st.Id == id);
        }

        public StockType GetByName(string name)
        {
            return _stockTypeRepository.GetByName(name);
        }

        public void Update(StockType stockType)
        {
            //var existingStockType = _stockTypeRepository.GetById(stockType.Id);
            //if(existingStockType == null)
            //{
            //    throw new Exception("Güncellenecek stok türü bulunamadı.");
            //}
            _stockTypeRepository.Update(stockType);
        }
    }
}
