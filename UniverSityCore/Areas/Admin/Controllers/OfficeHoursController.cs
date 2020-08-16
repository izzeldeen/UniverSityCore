using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniverSity.DataAccess.Data;
using UniverSity.Models;

namespace UniverSityCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OfficeHoursController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OfficeHoursController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var hour = _db.Officehours;

            return View(hour);
        }

        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(OfficeHours hour)
        {
            if (ModelState.IsValid)
            {
                _db.Officehours.Add(hour);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View();
        }


        public IActionResult Delete(int id)
        {
            var hour = _db.Officehours.Find(id);

            if (hour != null)
            {
                return View(hour);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(OfficeHours hour)
        {


            if (ModelState.IsValid)
            {
                _db.Officehours.Remove(hour);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var hour = _db.Officehours.Find(id);

            if (hour != null)
            {
                return View(hour);
            }

            return RedirectToAction(nameof(Index));


        }
        [HttpPost]
        public IActionResult Edit(OfficeHours hour)
        {
            if (ModelState.IsValid)
            {
                _db.Officehours.Update(hour);

                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View(hour);
        }
    }
}