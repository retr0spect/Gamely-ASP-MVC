using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gamely.Models;

namespace Gamely.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = getCustomers();
            return View(customers);
        }

        private IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Aditya"},
                new Customer {Id = 2, Name = "Ronald"}
            };
        }

        public ActionResult Details(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}