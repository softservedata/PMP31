using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicsShop.Models;
using System.Web.Security;
using PagedList;
using System.Data;

using DAL;


namespace ElectronicsShop.Controllers
{
    public class CategoryManagController : Controller
    {
        //-------------------List---------------------------
        [HttpGet]
        public ActionResult Index(int page = 1, int pageSize = 6)
        {

            CategoriesDAL c = new CategoriesDAL();
            List<CategoryDTO> categoryList = c.GetCategories();
            List<CategoryModel> modelList = new List<CategoryModel>();
            int i = 0;
            foreach (CategoryDTO x in categoryList)
            {
                CategoryModel m = new CategoryModel();
                m.id_categ = categoryList[i].id_categ;
                m.categ_name = categoryList[i].categ_name;
                modelList.Add(m);
                i++;
            }
            
            PagedList<CategoryModel> model = new PagedList<CategoryModel>(modelList, page, pageSize);
            return View(model);
        }

        //--------------------Add--------------------------------

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(CategoryModel model)
        {
            CategoriesDAL category = new CategoriesDAL();
            CategoryDTO dto = new CategoryDTO();
            dto.categ_name = model.categ_name;
            try
            {
                if (ModelState.IsValid)
                {
                    category.insertCategory(dto);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(model);
        }
        //--------------------Edit------------------------------
        [HttpGet]
        public ActionResult Edit(int id)
        {
            CategoriesDAL c = new CategoriesDAL();
            CategoryDTO dto = new CategoryDTO();
            dto = c.GetCategoryByID(id);
            CategoryModel model = new CategoryModel();
            model.id_categ = dto.id_categ;
            model.categ_name = dto.categ_name;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id,CategoryModel model)
        {
            CategoriesDAL c = new CategoriesDAL();
            CategoryDTO dto = new CategoryDTO();
            dto = c.GetCategoryByID(id);
            try
            {
                if (ModelState.IsValid)
                {
                    dto.categ_name = model.categ_name;
                    c.updateCategory(dto);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(model);
        }
        //----------------Delete-------------------
        
        public ActionResult Delete(int id)
        {
            CategoriesDAL c = new CategoriesDAL();
            CategoryDTO dto = new CategoryDTO();
            dto = c.GetCategoryByID(id);
            try
            {
                c.deleteCategory(dto);
                return RedirectToAction("Index");
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }

    }
}
