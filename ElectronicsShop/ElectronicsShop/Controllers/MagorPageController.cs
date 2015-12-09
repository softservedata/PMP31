using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Models;
using System.Web.Security;
using DAL;
using PagedList;

namespace ElectronicsShop.Controllers
{
    public class MagorPageController : Controller
    {
        //
        // GET: /MagorPage/

        public ActionResult Index()
        {
            return View();
        }
    }
}
