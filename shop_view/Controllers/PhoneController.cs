using Microsoft.AspNetCore.Mvc;
using shop_view.Models;
using shop_view.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shop_view.Controllers
{
    public class PhoneController : Controller
    {
        private static List<Phone> phones = new List<Phone>
        {
            new Phone { PhoneID = 1, Brand = "Phone A", PhoneCategory = Category.classic, Price = 500, Description = "Description A" },
            new Phone { PhoneID = 2, Brand = "Phone B", PhoneCategory = Category.dicount, Price = 600, Description = "Description B" },
            new Phone { PhoneID = 3, Brand = "Phone C", PhoneCategory = Category.premium, Price = 700, Description = "Description C" }
        };

        public IActionResult Index()
        {
            return View(phones);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            if (ModelState.IsValid)
            {
                phone.PhoneID = phones.Max(p => p.PhoneID) + 1;
                phones.Add(phone);
                return RedirectToAction("Index");
            }

            return View(phone);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone phone = phones.Find(p => p.PhoneID == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        [HttpPost]
        public IActionResult Edit(int id, Phone phone)
        {
            if (id != phone.PhoneID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Phone existingPhone = phones.Find(p => p.PhoneID == id);
                if (existingPhone == null)
                {
                    return NotFound();
                }

                existingPhone.Brand = phone.Brand;
                existingPhone.PhoneCategory = phone.PhoneCategory;
                existingPhone.Price = phone.Price;
                existingPhone.Description = phone.Description;

                return RedirectToAction("Index");
            }

            return View(phone);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone phone = phones.Find(p => p.PhoneID == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Phone phone = phones.Find(p => p.PhoneID == id);
            if (phone != null)
            {
                phones.Remove(phone);
            }
            return RedirectToAction("Index");
        }
    }
}
