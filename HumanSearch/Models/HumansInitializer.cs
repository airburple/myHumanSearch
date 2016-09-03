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
            new Human { Id= 1, Name = "Carson Alexandere", Address = "111 5th Street", Age = 19 ,FileName ="carsonalexander.jpg", Interests= "Volleyball camping hiking", Hair ="Brown" },
            new Human { Id= 2, Name = "Ben Felix", Address = "222 6th BLVD", Age = 30 ,FileName ="benfelix.jpg", Interests= "Volleyball  hiking", Hair ="Bald" },
            new Human { Id= 3, Name = "Susan Jones", Address = "333 11th Street", Age = 22 ,FileName ="susanjones.jpg", Interests= "Volleyball ", Hair ="Blonde" },
            new Human { Id= 4, Name = "Ben Hope", Address = "444 14th Ave", Age = 65 ,FileName ="benhope.jpg", Interests= "camping hiking", Hair ="Brown" },
            new Human { Id= 5, Name = "James Alexander", Address = "555 7th Street", Age = 40 ,FileName ="jamesalexander.jpg", Interests= "Racing", Hair ="Brown" },

            };

            humans.ForEach(s => context.human.Add(s));
            context.SaveChanges();
        }
    }
}