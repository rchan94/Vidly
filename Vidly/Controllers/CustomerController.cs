using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: List of all Customers
        [Route("Customer/Index")]
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // GET: Customer Details
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
            
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name = "Superman", Id = 1 },
                new Customer {Name = "Batman", Id = 2 }
            };
        }
    }
}