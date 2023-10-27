using Microsoft.AspNetCore.Mvc;
using shop_view.Models;
using shop_view.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shop_view.Controllers
{
    public class ScreenController : Controller
    {
        private static List<Screen> screens = new List<Screen>
        {
            new Screen { ScreenID = 1, Brand = "Screen A", ScreenCategory = Category.classic, Price = 400, Description = "Description A", Inches = 27 },
            new Screen { ScreenID = 2, Brand = "Screen B", ScreenCategory = Category.classic, Price = 120, Description = "Description B", Inches = 24 },
            new Screen { ScreenID = 3, Brand = "Screen C", ScreenCategory = Category.premium, Price = 1200, Description = "Description C", Inches = 43 }
        };

        public IActionResult Index()
        {
            return View(screens);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Screen screen)
        {
            if (ModelState.IsValid)
            {
                screen.ScreenID = screens.Any() ? screens.Max(s => s.ScreenID) + 1 : 1;
                screens.Add(screen);
                return RedirectToAction("Index");
            }

            return View(screen);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screen screen = screens.FirstOrDefault(s => s.ScreenID == id);
            if (screen == null)
            {
                return NotFound();
            }

            return View(screen);
        }

        [HttpPost]
        public IActionResult Edit(int id, Screen screen)
        {
            if (id != screen.ScreenID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Screen existingScreen = screens.FirstOrDefault(s => s.ScreenID == id);
                if (existingScreen == null)
                {
                    return NotFound();
                }

                existingScreen.Brand = screen.Brand;
                existingScreen.ScreenCategory = screen.ScreenCategory;
                existingScreen.Price = screen.Price;
                existingScreen.Description = screen.Description;
                existingScreen.Inches = screen.Inches;

                return RedirectToAction("Index");
            }

            return View(screen);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screen screen = screens.FirstOrDefault(s => s.ScreenID == id);
            if (screen == null)
            {
                return NotFound();
            }

            return View(screen);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Screen screen = screens.FirstOrDefault(s => s.ScreenID == id);
            if (screen != null)
            {
                screens.Remove(screen);
            }
            return RedirectToAction("Index");
        }
    }
}
