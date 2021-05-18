using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class Car
    {

        public Car(string id, string make, string model, string description, int year, int price, string imgUrl)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Description = description;
            this.Year = year;
            this.Price = price;
            this.ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public string ImgUrl { get; set; }

    }
}