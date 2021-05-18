using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class House
    {

        public House(string id, int bedrooms, int bathrooms, int levels, string description, int year, int price, string imgUrl)
        {
            this.Id = id;
            this.Bedrooms = bedrooms;
            this.Bathrooms = bathrooms;
            this.Levels = levels;
            this.Description = description;
            this.Year = year;
            this.Price = price;
            this.ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public int Levels { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public string ImgUrl { get; set; }



    }
}