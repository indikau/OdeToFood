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
                new Resturant {Id =2, Name= "Tersiguels", Cuisine= CuisineType.French},
                new Resturant {Id =3, Name= "Mango Grove", Cuisine= CuisineType.Indian},
            };
        }

        public void Add(Resturant resturant)
        {
            resturants.Add(resturant);
            resturant.Id = resturants.Max(r => r.Id) + 1;
        }

        public void Update(Resturant resturant)
        {
            var existing = Get(resturant.Id);
            if (existing != null)
            {
                existing.Name = resturant.Name;
                existing.Cuisine = resturant.Cuisine;

            }

        }

        public Resturant Get(int id)
        {
            return resturants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return resturants.OrderBy(r => r.Name);
        }
    }
}
