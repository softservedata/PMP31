using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Models;
using System.Web.Security;

using DAL;

namespace ElectronicsShop.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/ 
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                UsersDAL u = new UsersDAL();
                UserDTO dto1 = new UserDTO();
                UserDTO dto2 = new UserDTO();
                dto1 = u.GetUserByLogin(model.login);
                dto2 = u.GetUserByPassword(model.password);
                if ((dto1 != null) && (dto2 != null))
                {
                    if (dto1.id_user == dto2.id_user)
                    {
                        //FormsAuthentication.SetAuthCookie(model.login,false);
                        return RedirectToAction("Index","MagorPage");
                    }
                    else ModelState.AddModelError("", "Invalid login or password");
                }
                else { ModelState.AddModelError("", "Invalid login or password"); }   
            }
            return View();
        }

    }
}
