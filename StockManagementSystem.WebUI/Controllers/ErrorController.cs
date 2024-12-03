using Microsoft.AspNetCore.Mvc;

namespace StockManagementSystem.WebUI.Controllers
{
    public class ErrorController : Controller
    {
        //404 sayfası
        public IActionResult NotFound()
        {
            return View("NotFound");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
