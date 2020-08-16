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
    public class PublicationsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PublicationsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var publish = _db.Publications.ToList();

            return View(publish);
        } 

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Publications publications)
        {
            if(ModelState.IsValid)
            {
                _db.Publications.Add(publications);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View();
        }


        public IActionResult Delete(int id)
        {
            var publish = _db.Publications.Find(id);

            if(publish != null)
            {
                return View(publish);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(Publications publications)
        {
           

           if(ModelState.IsValid)
            {
                _db.Publications.Remove(publications);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var publication = _db.Publications.Find(id);

            if(publication != null)
            {
                return View(publication);
            }

            return RedirectToAction(nameof(Index));

            
        }
        [HttpPost]
        public IActionResult Edit(Publications publications)
        {
            if(ModelState.IsValid)
            {
                _db.Publications.Update(publications);

                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }

            return View(publications);


        }

    }
}
