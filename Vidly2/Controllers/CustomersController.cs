using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        //Create the db context
        private ApplicationDbContext _context;

        //Initialize the db context in the constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Properly dispose of the db context
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

    }
}