using System.Collections.Generic;
using cs_gregslist.Models;

namespace cs_gregslist.DB
{
    public static class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>() { };
        public static List<House> Houses { get; set; } = new List<House>() { };
        public static List<Job> Jobs { get; set; } = new List<Job>() { };

    }
}