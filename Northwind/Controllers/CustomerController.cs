using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class CustomerController : Controller
    {
        // this controller depends on the NorthwindRepository
        private NorthwindContext _northwindContext;
        public CustomerController(NorthwindContext db) => _northwindContext = db;

        public ActionResult Index() => View(_northwindContext.Customers.OrderBy(c => c.CompanyName));

        public ActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                if (_northwindContext.Customers.Any(b => b.CompanyName == model.CompanyName))
                {
                    ModelState.AddModelError("", "Company name must be unique");
                }
                else
                {
                    _northwindContext.AddCustomer(model);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}