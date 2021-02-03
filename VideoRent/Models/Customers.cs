using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VideoRent.Models
{
    public class Customers
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]

        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime? dateOfBirth { get; set; }
        public bool isSubscribedToNewsLetter{ get; set; }
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        public int MembershipTypesId { get; set; }
    }
}