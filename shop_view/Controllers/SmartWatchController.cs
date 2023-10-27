using Microsoft.AspNetCore.Mvc;
using shop_view.Models;
using shop_view.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shop_view.Controllers
{
    public class SmartWatchController : Controller
    {
        private static List<SmartWatch> smartWatches = new List<SmartWatch>
        {
            new SmartWatch { SWID = 1, Brand = "SmartWatch A", SWCategory = Category.classic, Price = 150, Description = "Description A" },
            new SmartWatch { SWID = 2, Brand = "SmartWatch B", SWCategory = Category.classic, Price = 200, Description = "Description B" },
            new SmartWatch { SWID = 3, Brand = "SmartWatch C", SWCategory = Category.premium, Price = 250, Description = "Description C" }
        };

        public IActionResult Index()
        {
            return View(smartWatches);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SmartWatch smartWatch)
        {
            if (ModelState.IsValid)
            {
                smartWatch.SWID = smartWatches.Any() ? smartWatches.Max(sw => sw.SWID) + 1 : 1;
                smartWatches.Add(smartWatch);
                return RedirectToAction("Index");
            }

            return View(smartWatch);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SmartWatch smartWatch = smartWatches.FirstOrDefault(sw => sw.SWID == id);
            if (smartWatch == null)
            {
                return NotFound();
            }

            return View(smartWatch);
        }

        [HttpPost]
        public IActionResult Edit(int id, SmartWatch smartWatch)
        {
            if (id != smartWatch.SWID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                SmartWatch existingSmartWatch = smartWatches.FirstOrDefault(sw => sw.SWID == id);
                if (existingSmartWatch == null)
                {
                    return NotFound();
                }

                existingSmartWatch.Brand = smartWatch.Brand;
                existingSmartWatch.SWCategory = smartWatch.SWCategory;
                existingSmartWatch.Price = smartWatch.Price;
                existingSmartWatch.Description = smartWatch.Description;

                return RedirectToAction("Index");
            }

            return View(smartWatch);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SmartWatch smartWatch = smartWatches.FirstOrDefault(sw => sw.SWID == id);
            if (smartWatch == null)
            {
                return NotFound();
            }

            return View(smartWatch);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            SmartWatch smartWatch = smartWatches.FirstOrDefault(sw => sw.SWID == id);
            if (smartWatch != null)
            {
                smartWatches.Remove(smartWatch);
            }
            return RedirectToAction("Index");
        }
    }
}
