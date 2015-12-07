using Lesson.App;
using System.Web.Mvc;

namespace Lesson.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersService _ordersService;

        public OrdersController()
        {
            _ordersService = new OrdersService();
        }

        // GET: Orders
        public ActionResult Index()
        {
            var model = _ordersService.GetOrders();
            return View(model);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            var model = _ordersService.GetOrderById(id);
            return View(model);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orders/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
