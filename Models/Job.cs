using System;
using System.ComponentModel.DataAnnotations;

namespace cs_gregslist.Models
{
    public class Job
    {

        public Job(string id, string company, string jobTitle, string description, int rate, int hours, string imgUrl)
        {
            this.Id = id;
            this.Company = company;
            this.JobTitle = jobTitle;
            this.Description = description;
            this.Rate = rate;
            this.Hours = hours;
            this.ImgUrl = imgUrl;
        }

        public string Id { get; set; }

        public string Company { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }

        public int Rate { get; set; }

        public int Hours { get; set; }

        public string ImgUrl { get; set; }

    }
}