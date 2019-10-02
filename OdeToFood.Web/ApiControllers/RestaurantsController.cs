using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;

namespace OdeToFood.Web.ApiControllers
{
    public class RestaurantsController : ApiController
    {
        private readonly IResturantData db;

        public RestaurantsController(IResturantData db)
        {
            this.db = db;
        }

        public IEnumerable<Restaurant> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
