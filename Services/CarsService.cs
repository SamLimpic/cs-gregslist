using System;
using System.Collections.Generic;
using cs_gregslist.DB;
using cs_gregslist.Models;

namespace cs_gregslist.Services
{
    public class CarsService
    {
        public IEnumerable<Car> GetAll()
        // IEnumerable takes the place of any collection type (List, Array, etc...)

        {
            return FakeDB.Cars;
            // This is the temporary placeholder before using a real DB
        }

        internal Car GetById(string id)
        {
            Car found = FakeDB.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new System.Exception("Invalid Id");
            }
            return found;
        }

        internal Car Create(Car newCar)
        {
            FakeDB.Cars.Add(newCar);
            return newCar;
        }

        internal Car Edit(Car editCar)
        {
            Car oldCar = GetById(editCar.Id);
            // This longform method is temporary, since we only have a FakeDB
            oldCar.Make = editCar.Make;
            oldCar.Model = editCar.Model;
            oldCar.Description = editCar.Description;
            oldCar.Year = editCar.Year;
            oldCar.Price = editCar.Price;
            oldCar.ImgUrl = editCar.ImgUrl;

            return oldCar;
        }

        internal void DeleteCar(string id)
        {
            Car found = GetById(id);
            FakeDB.Cars.Remove(found);
        }
    }
}