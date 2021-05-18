using System.Collections.Generic;
using cs_gregslist.Models;

namespace cs_gregslist.DB
{
    public static class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>() {
            new Car("Dodge", "Charger", "I live my life a quarter-mile at a time", 1970, 22000, "https://static0.hotcarsimages.com/wordpress/wp-content/uploads/2019/03/Velgen20.com_.jpg?q=50&fit=crop&w=960&h=500"),

            new Car("Jaguar", "E-Type", "Yeah baby!", 1970, 1000000, "https://pbs.twimg.com/media/Easm5dNXkAACcUn.jpg"),

            new Car("Dodge", "Monaco", "We're on a mission from God", 1974, 5000, "https://static2.hotcarsimages.com/wordpress/wp-content/uploads/2020/11/bluesmobile.jpg")
        };
        public static List<House> Houses { get; set; } = new List<House>() {
            new House(2, 1, 1, "Bother burgling and everything to do with it! I wish I was at home in my nice hole by the fire, with the kettle just beginning to sing!", 2000, 111, "https://i2.wp.com/www.edwud.com/wp-content/uploads/2020/07/bag-end-hobbiton.jpg?fit=1400%2C933&ssl=1"),

            new House(400, 1, 7, "I solemnly swear I am up to no good", 1500, 0, "https://images.ctfassets.net/usf1vwtuqyxm/3QQaEkThAnIAiXveGhJYD9/f79a571dbe9fd456d65e783040601fdc/hogwarts-castle-.jpg?fm=jpg"),

            new House(1, 1, 1, "What do you think he does up there, throw parties?  No... he broods.", 1954, 1000000, "https://i.pinimg.com/originals/1a/d5/26/1ad52627c53138911721143607b7670d.jpg")
        };
        public static List<Job> Jobs { get; set; } = new List<Job>() {
            new Job("Job Corp", "Computer Man", "Do the computer thing, we'll give you the money!", 15, 60, "https://theenglishfarm.com/sites/default/files/styles/featured_image/public/harold_2.jpg?itok=NGsRc1Co"),

            new Job("Business Inc", "Business Guy", "Do the business for us!  We'll give the money to you!", 20, 70, "https://hungarytoday.hu/wp-content/uploads/2018/02/18ps27.jpg"),

            new Job("Work and Co", "Manager Man", "Make sure the business does the business, and the money will be your money.", 25, 80, "https://i.redd.it/l0j5v1u7pg221.jpg")
        };

    }
}