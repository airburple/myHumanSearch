using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HumanSearch.Models
{
    public class Human
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Hair { get; set; }
        public string Interests { get; set; }
        public string FileName { get; set; }
    }
}