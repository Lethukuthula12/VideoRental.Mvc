using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRent.Models
{
    public class AddCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customers Customer { get; set; }
    }
}