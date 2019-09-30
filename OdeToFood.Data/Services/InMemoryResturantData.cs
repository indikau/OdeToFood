using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryResturantData : IResturantData
    {
        List<Resturant> resturants;

        public InMemoryResturantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant {Id =1, Name= "Scott Pizza", Cuisine= CuisineType.Italian},
                new Resturant {Id =1, Name= "Tersiguels", Cuisine= CuisineType.French},
                new Resturant {Id =1, Name= "Mango Grove", Cuisine= CuisineType.Indian},
            };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return resturants.OrderBy(r => r.Name);
        }
    }
}
