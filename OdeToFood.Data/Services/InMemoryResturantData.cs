﻿using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryResturantData : IResturantData
    {
        List<Restaurant> restaurants;

        public InMemoryResturantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id =1, Name= "Scott Pizza", Cuisine= CuisineType.Italian},
                new Restaurant {Id =2, Name= "Tersiguels", Cuisine= CuisineType.French},
                new Restaurant {Id =3, Name= "Mango Grove", Cuisine= CuisineType.Indian},
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;

            }

        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
