using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumanSearch.Models
{
    public class HumansInitializer : System.Data.Entity.DropCreateDatabaseAlways<HumanDBContext>
    {

        protected override void Seed(HumanDBContext context)
        {
            var humans = new List<Human>
            {
            new Human { Id= 1, Name = "Carla Alexandere", Address = "111 5th Street", Age = 59 ,FileName ="Imgs/woman1.jpg", Interests= "volleyball, camping, hiking", Hair ="Brown" },
            new Human { Id= 2, Name = "Ben Felix", Address = "222 6th BLVD", Age = 30 ,FileName ="Imgs/man1.jpg", Interests= "volleyball,  hiking", Hair ="Black" },
            new Human { Id= 3, Name = "Susan Jones", Address = "333 11th Street", Age = 33 ,FileName ="Imgs/woman2.jpg", Interests= "volleyball ", Hair ="Black" },
            new Human { Id= 4, Name = "Ben Hope", Address = "444 14th Ave", Age = 65 ,FileName ="Imgs/man3.jpg", Interests= "camping, hiking", Hair ="Brown" },
            new Human { Id= 5, Name = "James Alexander", Address = "555 7th Street", Age = 30 ,FileName ="Imgs/man2.jpg", Interests= "horse racing", Hair ="Brown" },

            };

            humans.ForEach(s => context.human.Add(s));
            context.SaveChanges();
        }
    }
}