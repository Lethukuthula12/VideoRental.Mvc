using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VideoRent.Models
{
    public class Movie
    {

       public int id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; }
        public byte NumberOfStock { get; set; }
        public Genre Genre { get; set; }
        public int Genreid { get; set; }

    }
}