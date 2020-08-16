using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniverSity.DataAccess.Data;
using UniverSity.Models;

namespace UniverSityCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles= "Admin")]
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PostController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _db.Posts.ToListAsync();

            return View(res);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create(Post post)
        {
            if(ModelState.IsValid)
            {
                _db.Posts.Add(post);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return View(post);
        }


        public async Task<IActionResult> Edit(int id)
        {
           var res = await  _db.Posts.FindAsync(id);
            if(res != null )
            {
                return View(res);
            }


            return View(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            if(!ModelState.IsValid)
            {
                return View(post);

            }

             _db.Posts.Update(post);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var res = await _db.Posts.FindAsync(id);
            if (res != null)
            {
                return View(res);
            }


            return View(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Post post)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            _db.Posts.Remove(post);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



    }
}
