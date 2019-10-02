﻿using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.Models
{
    public class Resturant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
