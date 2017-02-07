using MVC_LayoutDBDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LayoutDBDemo.Controllers
{
    public class HomeController : Controller
    {
        List<Customer> customerList = new List<Customer>();
        List<Product> productList = new List<Product>();

        public HomeController()
        {
            customerList.Add(new Customer { CustomerID = 1, CustomerName = "Accenture" });
            customerList.Add(new Customer { CustomerID = 2, CustomerName = "TCS" });
            customerList.Add(new Customer { CustomerID = 3, CustomerName = "Cognizant" });

            productList.Add(new Product { ProductID = 1, ProductName = "Mobile", Price = 1000 });
            productList.Add(new Product { ProductID = 2, ProductName = "Tab", Price = 2000 });
            productList.Add(new Product { ProductID = 3, ProductName = "Music System", Price = 3000 });
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerData()
        {
            return View(customerList);
        }

        public ActionResult ProductData()
        {
            return View(productList);
        }

        public ActionResult CustomerPartialDemo()
        {
            return PartialView(customerList);
        }
        
        public ActionResult ProductPartialDemo()
        {
            return PartialView(productList);
        }

        public ActionResult DisplayPartialViews()
        {
            return View();
        }
    
    }
}