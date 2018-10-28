using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Data;
using pro1.Models;
namespace pro1.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private Entities2 db = new Entities2();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hotels()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Details(int? id)
        {
            Hotel hotels = db.Hotels.Find(id);
            return View(hotels);
        }

        public ActionResult BookHotels2()
        {

            String cityname = Request["City"].ToString();

            //if (!string.IsNullOrEmpty(cityname))
            //    cityname = "Ankleshwar";
            var h = from m in db.Hotels
                    where  m.City == cityname
                    select m;

            // ViewData["hotels"] = h.ToList();
            return View(h.ToList());

        }

        //public ActionResult BookRoom()
        //{
        //    int room = Request[""]
        //}


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Package()
        {
            ViewBag.Message = "Your Package page.";

            return View();
        }
    }
}