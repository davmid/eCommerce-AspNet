using Microsoft.AspNetCore.Mvc;
using shop_view.Models;

namespace shop_view.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public IActionResult Form(Data data)
        {
            if (ModelState.IsValid)
            {
                return View("Results", data);
            }
            else return View();
        }

        public IActionResult Result(Data data)
        {
            return View(data);
        }
    }
}
