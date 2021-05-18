using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class House
    {

        public House(int bedrooms, int bathrooms, int levels, string description, int year, int price, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            Levels = levels;
            Description = description;
            Year = year;
            Price = price;
            ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Bedrooms { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Bathrooms { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Levels { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1500, 2022)]
        public int Year { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        public string ImgUrl { get; set; } = "http://www.fillmurray.com/250/250";



    }
}