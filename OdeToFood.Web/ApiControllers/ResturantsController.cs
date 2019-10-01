using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;

namespace OdeToFood.Web.ApiControllers
{
    public class ResturantsController : ApiController
    {
        private readonly IResturantData db;

        public ResturantsController(IResturantData db)
        {
            this.db = db;
        }

        public IEnumerable<Resturant> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
