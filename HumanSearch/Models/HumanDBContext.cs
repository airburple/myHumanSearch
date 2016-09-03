using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HumanSearch.Models
{
    public class HumanDBContext : DbContext
    {
        public HumanDBContext() : base("HumanDBContext")
        {
        }

        public DbSet<Human> human { get; set; }
    }
}