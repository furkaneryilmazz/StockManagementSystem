using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Core.Entities;

namespace StockManagementSystem.WebUI.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockService _stockService;
        private readonly IStockClassService _stockClassService;
        private readonly IStockUnitService _stockUnitService;
        private readonly IStockTypeService _stockTypeService;

        public StockController(IStockService stockService, IStockClassService stockClassService, IStockUnitService stockUnitService, IStockTypeService stockTypeService)
        {
            _stockService = stockService;
            _stockClassService = stockClassService;
            _stockUnitService = stockUnitService;
            _stockTypeService = stockTypeService;
        }

        public IActionResult Index()
        {
            var stocks = _stockService.GetAll();
            ViewBag.GetStockClass = GetStockClass();
            ViewBag.GetUnitCode = GetUnitCode();
            ViewBag.GetStockType = GetStockType();
            return View(stocks);
        }

        public IActionResult CreateStock()
        {
            ViewBag.GetStockClass = GetStockClass();
            ViewBag.GetStockType = GetStockType();
            ViewBag.GetUnitCode = GetUnitCode();
            return View();
        }
        [HttpPost]
        public IActionResult CreateStock(Stock stock)
        {
            if (ModelState.IsValid)
            {
                _stockService.Add(stock);
                return RedirectToAction("Index");
            }
            ViewBag.GetStockClass = GetStockClass();
            ViewBag.GetStockType = GetStockType();
            ViewBag.GetUnitCode = GetUnitCode();
            return View(stock);
        }

        public  IActionResult EditStock(int id)
        {
            var stock = _stockService.GetById(id);
            ViewBag.GetStockClass = GetStockClass();
            ViewBag.GetStockType = GetStockType();
            ViewBag.GetUnitCode = GetUnitCode();
            return View(stock);
        }
        [HttpPost]
        public IActionResult EditStock(Stock stock)
        {
            if (ModelState.IsValid)
            {
                _stockService.Update(stock);
                return RedirectToAction("Index");
            }
            ViewBag.GetStockClass = GetStockClass();
            ViewBag.GetStockType = GetStockType();
            ViewBag.GetUnitCode = GetUnitCode();
            return View(stock);
        }

        public IActionResult DeleteStock(int id)
        {
            _stockService.Delete(id);
            return RedirectToAction("Index");
        }

        public List<SelectListItem> GetStockClass()
        {
            return _stockClassService.GetAll().Select(x => new SelectListItem
            {
                Text = x.StockClassName,
                Value = x.Id.ToString()
            }).ToList();
        }
        public List<SelectListItem> GetUnitCode()
        {
            return _stockUnitService.GetAll().Select(x => new SelectListItem
            {
                Text = x.StockUnitCode,
                Value = x.Id.ToString()
            }).ToList();
        }

        public List<SelectListItem> GetStockType()
        {
            return _stockTypeService.GetAll().Select(x => new SelectListItem
            {
                Text = x.StockTypeName,
                Value = x.Id.ToString()
            }).ToList();
        }
    }
}
