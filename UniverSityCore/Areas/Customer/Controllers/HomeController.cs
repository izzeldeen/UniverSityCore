using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UniverSity.DataAccess.Data;
using UniverSityCore.Models;

namespace UniverSityCore.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db , SignInManager<IdentityUser> signInManager, ILogger<LogoutModel> logger)
        {
            _db = db;
            _signInManager = signInManager;
            _logger = logger;

        }
        public IActionResult Index()
        {
            

            var Course = _db.Courses;

            return View(Course);
        }

        public IActionResult Postings()
        {
            return View();
        }

        public IActionResult Dashbord()
        {
            return View();
        }


        public IActionResult Literature()
        {
            var publications = _db.Publications;
            return View(publications);
        }
        public IActionResult OfficeOur()
        {
            var officeHour = _db.Officehours;
            return View(officeHour);
        }


        public IActionResult Courses()
        {
            var Course = _db.Courses;

            return View(Course);
        }

        public IActionResult Cv()
        {
            var cv = _db.Cvs.FirstOrDefault();

            return View(cv);
        }

        public async Task<IActionResult> Announcement()
        {


            var Announ = await _db.Announcements.ToListAsync();

            return View(Announ);
        }


        public async Task<IActionResult> GetCourse(int id)
        {
            var res = await  _db.Courses.FindAsync(id);

            if (res != null)
            {
                return View(res);
            }

            
                return NotFound();

        }

        public async Task<IActionResult> Post()
        {
            var res = await _db.Posts.ToListAsync();

            if (res != null)
            {
                return View(res);
            }


            return NotFound();

        }



    }
}
