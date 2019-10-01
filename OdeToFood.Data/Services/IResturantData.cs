using OdeToFood.Data.Models;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant Get(int id);

        void Add(Resturant resturant);
    }
}
