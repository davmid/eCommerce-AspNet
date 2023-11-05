using Microsoft.AspNetCore.Mvc;
using shop_view.Models;

namespace shop_view.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Data data)
        {
            return View("Result", data);
        }

        public IActionResult Result(Data data)
        {
            return View(data);
        }
    }
}
