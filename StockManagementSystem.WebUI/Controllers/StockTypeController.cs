using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Context;

namespace StockManagementSystem.WebUI.Controllers
{
    public class StockTypeController : Controller
    {
        private readonly IStockTypeService _stockTypeService;
        private readonly StockManagementContext _context;

        public StockTypeController(IStockTypeService stockTypeService, StockManagementContext context)
        {
            _stockTypeService = stockTypeService;
            _context = context;
        }

        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            var stockTypes = _stockTypeService.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalRecords = _stockTypeService.GetAll().Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalRecords = totalRecords;

            return View(stockTypes);
        }

        public IActionResult CreateStockType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStockType(StockType stockType)
        {
            if (ModelState.IsValid)
            {
                _stockTypeService.Add(stockType);
                return RedirectToAction("Index");
            }
            return View(stockType);
        }

        public IActionResult EditStockType(int id)
        {
            var stockType = _stockTypeService.GetById(id);
            if(stockType == null)
            {
                return NotFound();
            }
            return View(stockType);
        }
        [HttpPost]
        public IActionResult EditStockType(StockType stockType)
        {
            if (ModelState.IsValid)
            {
                _stockTypeService.Update(stockType);
                return RedirectToAction("Index");
            }
            return View(stockType);
        }

        public IActionResult DeleteStockType(int id)
        {
            var stockType = _stockTypeService.GetById(id);
            if(stockType == null)
            {
                return NotFound();
            }
            _stockTypeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
