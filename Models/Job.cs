using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class Job
    {

        public Job(string company, string jobTitle, string description, int rate, int hours, string imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Company = company;
            JobTitle = jobTitle;
            Description = description;
            Rate = rate;
            Hours = hours;
            ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string JobTitle { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(15, int.MaxValue)]
        public int Rate { get; set; }

        [Required]
        [Range(10, int.MaxValue)]
        public int Hours { get; set; }

        public string ImgUrl { get; set; } = "http://www.fillmurray.com/250/250";

    }
}