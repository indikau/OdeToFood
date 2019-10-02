using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class ResturantsController : Controller
    {
        private readonly IResturantData db;

        public ResturantsController(IResturantData db)
        {
            this.db = db;
        }

        // GET: Resturants
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant resturant)
        {
            //if (string.IsNullOrEmpty(resturant.Name))
            //{
            //    ModelState.AddModelError(nameof(resturant.Name), "The Name is reqired");
            //}
            if (ModelState.IsValid)
            {
                db.Add(resturant);
                return RedirectToAction("Details", new { id = resturant.Id });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant resturant)
        {
            if (ModelState.IsValid)
            {
                db.Update(resturant);
                return RedirectToAction("Details", new { id = resturant.Id });
            }
            return View();
        }
    }
}