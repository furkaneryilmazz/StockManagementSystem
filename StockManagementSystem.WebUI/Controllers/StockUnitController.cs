using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;
using StockManagementSystem.Data.Context;

namespace StockManagementSystem.WebUI.Controllers
{
    public class StockUnitController : Controller
    {
        private readonly StockManagementContext _context;
        private readonly IStockUnitService _stockUnitService;
        private readonly IStockTypeService _stockTypeService;
        private readonly IStockQuantityUnitService _stockQuantityUnitService;
        private readonly IStockCurrencyUnitService _currencyUnitService;

        public StockUnitController(IStockUnitService stockUnitService, IStockTypeService stockTypeService, IStockQuantityUnitService stockQuantityUnitService, IStockCurrencyUnitService currencyUnitService, StockManagementContext context)
        {
            _stockUnitService = stockUnitService;
            _stockTypeService = stockTypeService;
            _stockQuantityUnitService = stockQuantityUnitService;
            _currencyUnitService = currencyUnitService;
            _context = context;
        }

        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            var stockUnits = _stockUnitService.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalRecords = _stockUnitService.GetAll().Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalRecords = totalRecords;

            ViewBag.CurrencyUnits = GetCurrencyUnits();
            ViewBag.QuantityUnits = GetQuantityUnits();
            ViewBag.StockTypes = GetStockTypes();
            return View(stockUnits);
        }

        public IActionResult CreateStockUnit()
        {
            ViewBag.CurrencyUnits = GetCurrencyUnits();
            ViewBag.QuantityUnits = GetQuantityUnits();
            ViewBag.StockTypes = GetStockTypes();
            return View();
        }
        [HttpPost]
        public IActionResult CreateStockUnit(StockUnit stockUnit)
        {
            if (ModelState.IsValid)
            {
                _stockUnitService.Add(stockUnit);
                return RedirectToAction("Index");
            }
            ViewBag.CurrencyUnits = GetCurrencyUnits();
            ViewBag.QuantityUnits = GetQuantityUnits();
            ViewBag.StockTypes = GetStockTypes();
            return View(stockUnit);
        }
        public IActionResult EditStockUnit(int id)
        {
            var stockUnit = _stockUnitService.GetById(id);
            ViewBag.CurrencyUnits = GetCurrencyUnits();
            ViewBag.QuantityUnits = GetQuantityUnits();
            ViewBag.StockTypes = GetStockTypes();
            return View(stockUnit);
        }
        [HttpPost]
        public IActionResult EditStockUnit(StockUnit stockUnit)
        {
            if (ModelState.IsValid)
            {
                _stockUnitService.Update(stockUnit);
                return RedirectToAction("Index");
            }
            ViewBag.CurrencyUnits = GetCurrencyUnits();
            ViewBag.QuantityUnits = GetQuantityUnits();
            ViewBag.StockTypes = GetStockTypes();
            return View(stockUnit);
        }

        public IActionResult DeleteStockUnit(int id)
        {
            _stockUnitService.Delete(id);
            return RedirectToAction("Index");
        }

        public List<SelectListItem> GetStockTypes()
        {
            return _stockTypeService.GetAll().Select(x => new SelectListItem
            {
                Text = x.StockTypeName,
                Value = x.Id.ToString()
            }).ToList();
        }
        public IEnumerable<SelectListItem> GetQuantityUnits()
        {
            var quantityUnits = _stockQuantityUnitService.GetAll();
            if (quantityUnits == null || !quantityUnits.Any())
            {
                return new List<SelectListItem>();
            }

            return quantityUnits.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.QuantityUnit
            });
        }

        public List<SelectListItem> GetCurrencyUnits()
        {
            var currencyUnits = _currencyUnitService.GetAll();
            if (currencyUnits == null || !currencyUnits.Any())
            {
                return new List<SelectListItem>();
            }

            return currencyUnits.Select(x => new SelectListItem
            {
                Text = x.CurrencyUnitMoney,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<StockUnit> GetAllIncludingStockType()
        {
            return _context.StockUnits
                           .Include(s => s.StockType)
                           .Include(s => s.StockQuantity)
                           .ToList();
        }

    }
}
