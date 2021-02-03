using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRent.Models;
using System.Data.Entity;

namespace VideoRent.Controllers
{
    public class CustomersController : Controller
    {

       private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.customers.Include(m => m.MembershipType).ToList();

           
            return View(customer);

        }
        public ActionResult New()
        {

            var Membership = _context.MembershiTypes.ToList();
            var ViewMode = new AddCustomerViewModel
            {
                MembershipTypes = Membership
            };
            return View(ViewMode);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.customers.Include(m => m.MembershipType).SingleOrDefault(i => i.id == id);
          
            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}