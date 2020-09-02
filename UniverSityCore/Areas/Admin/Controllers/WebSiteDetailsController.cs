using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using UniverSity.Models;
using UniverSity.Utility;


namespace UniverSityCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WebSiteDetailsController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public WebSiteDetailsController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }


        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(WebSiteDetails Details)
        {
            string webRootPath = _hostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images");
                var extenstion = Path.GetExtension(files[0].FileName);
                if (Details.Url != null)
                {
                    //this is an edit and we need to remove old image

                }
                using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                {
                    files[0].CopyTo(filesStreams);
                }
                SD.Url = @"/images/" + fileName + extenstion;
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            SD.Name = Details.Name;
            SD.PhoneNumber = Details.PhoneNumber;
            SD.Fax = Details.Fax;
            SD.Email = Details.Email;
            SD.Coluage = Details.Coulage;
            SD.Address = Details.Address;
            SD.Position = Details.Position;
            SD.FacebookUrl = Details.FacebookUrl;
            SD.TwitterUrl = Details.TwitterUrl;

            return View();
        }

    
    }
}