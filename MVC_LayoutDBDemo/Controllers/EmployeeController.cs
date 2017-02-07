using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_LayoutDBDemo.Models;
using System.Net;

namespace MVC_LayoutDBDemo.Controllers
{
    public class EmployeeController : Controller
    {
        Database1Entities service = new Database1Entities();              
          
        public ActionResult Details(int id)
        {
            Employee emp = service.Employees.Where(e => e.EmpID == id).SingleOrDefault();
            return View(emp);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                service.Employees.Add(emp);
                service.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
            
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if(id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee emp = service.Employees.Find(id);
            if (emp == null)
                return HttpNotFound();

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                service.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                service.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(emp);
            }
            
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee emp = service.Employees.Find(id);
            if (emp == null)
                return HttpNotFound();

            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Employees.Remove(service.Employees.Find(id));
            service.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View(service.Employees.ToList());
        }
    }
}