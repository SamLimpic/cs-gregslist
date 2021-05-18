using System;
using System.Collections.Generic;
using cs_gregslist.DB;
using cs_gregslist.Models;

namespace cs_gregslist.Services
{
    public class HousesService
    {
        public IEnumerable<House> GetAll()
        {
            return FakeDB.Houses;
            // This is the temporary placeholder before using a real DB
        }

        internal House GetById(string id)
        {
            House found = FakeDB.Houses.Find(c => c.Id == id);
            if (found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal House Create(House newHouse)
        {
            FakeDB.Houses.Add(newHouse);
            return newHouse;
        }

        internal House Edit(House editHouse)
        {
            House oldHouse = GetById(editHouse.Id);
            // This longform method is temporary, since we only have a FakeDB
            oldHouse.Bedrooms = editHouse.Bedrooms;
            oldHouse.Bathrooms = editHouse.Bathrooms;
            oldHouse.Levels = editHouse.Levels;
            oldHouse.Description = editHouse.Description;
            oldHouse.Year = editHouse.Year;
            oldHouse.Price = editHouse.Price;
            oldHouse.ImgUrl = editHouse.ImgUrl;

            return oldHouse;
        }

        internal void DeleteHouse(string id)
        {
            House found = GetById(id);
            FakeDB.Houses.Remove(found);
        }
    }
}