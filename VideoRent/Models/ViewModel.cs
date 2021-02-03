using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRent.Models
{
    public class ViewModel
    {
        public List<Customers> customers { get; set; }
        public List<Movie>  movies { get; set; }
    }
}