using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public class InMemoryResturantData : IResturantData
    {
        List<Resturant> resturants;

        public InMemoryResturantData()
        {

        }

        public IEnumerable<Resturant> GetAll()
        {
            return resturants;
        }
    }
}
