using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P111_CodeAcademy.DAL;
 
namespace P111_CodeAcademy.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext  _context;
        public HomeController(AppDbContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
     
            return View();
        }
        #region
        //public IActionResult Index()
        //{
        //    return Json(new
        //    {

        //        id = 1,
        //        name = "cavid",
        //        surname = "bashirov"
        //    });

        // return File("~/img/cards_img/1.jpg","image/jpg");

        // }
        #endregion

        public  IActionResult Error()
        {
            return Content("Siz gonderdiyiniz url duzgun deyil");
        }
    }
}
