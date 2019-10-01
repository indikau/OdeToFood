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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resturant resturant)
        {
            db.Add(resturant);
            return View();
        }
    }
}