using saadMehmood12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saadMehmood12.Controllers
{
    public class saadController : Controller
    {
        private saadDBContext db = new saadDBContext();

        public ActionResult Index(string searchString)
        {
            var saad = from m in db.saad
                       select m;
            if(!String.IsNullOrEmpty(searchString))
            {
                saad = saad.where(s => s.title.Contains(searchString));
            }
            return View(saad);

        }
    }
}