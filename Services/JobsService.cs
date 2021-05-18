using System;
using System.Collections.Generic;
using cs_gregslist.DB;
using cs_gregslist.Models;

namespace cs_gregslist.Services
{
    public class JobsService
    {
        public IEnumerable<Job> GetAll()
        {
            return FakeDB.Jobs;
            // This is the temporary placeholder before using a real DB
        }

        internal Job GetById(string id)
        {
            Job found = FakeDB.Jobs.Find(c => c.Id == id);
            if (found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal Job Create(Job newJob)
        {
            FakeDB.Jobs.Add(newJob);
            return newJob;
        }

        internal Job Edit(Job editJob)
        {
            Job oldJob = GetById(editJob.Id);
            // This longform method is temporary, since we only have a FakeDB
            oldJob.Company = editJob.Company;
            oldJob.JobTitle = editJob.JobTitle;
            oldJob.Description = editJob.Description;
            oldJob.Rate = editJob.Rate;
            oldJob.Hours = editJob.Hours;
            oldJob.ImgUrl = editJob.ImgUrl;

            return oldJob;
        }

        internal void DeleteJob(string id)
        {
            Job found = GetById(id);
            FakeDB.Jobs.Remove(found);
        }
    }
}