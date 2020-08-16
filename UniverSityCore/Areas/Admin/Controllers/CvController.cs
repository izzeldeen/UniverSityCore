using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniverSity.DataAccess.Data;
using UniverSity.Models;
using Microsoft.AspNetCore.Authorization;

namespace UniverSityCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CvController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CvController(ApplicationDbContext db)
        {
            _db = db;

        }
        public   IActionResult Edit()
        {
         var Details =    _db.Cvs.FirstOrDefault();

            return View(Details);
        }

        [HttpPost]
         public IActionResult Edit(Cv cv)
        {
            if(ModelState.IsValid)
            {
                _db.Cvs.Update(cv);
                _db.SaveChanges();

                return View(cv);
            }


            return NotFound();

        }
    }
}
