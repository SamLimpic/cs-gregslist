using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class Car
    {

        public Car(string make, string model, string description, int year, float price, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Model = model;
            Description = description;
            Year = year;
            Price = price;
            ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1800, 2022)]
        public int Year { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public float Price { get; set; }

        public string ImgUrl { get; set; } = "http://www.fillmurray.com/250/250";

    }
}