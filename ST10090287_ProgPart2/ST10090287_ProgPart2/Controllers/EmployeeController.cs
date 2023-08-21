using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ST10090287_ProgPart2.FData;
using ST10090287_ProgPart2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10090287_ProgPart2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        DBFarmer dBHelper;
        public EmployeeController(IConfiguration config)
        {
            dBHelper = new DBFarmer(config);
        }
        public ActionResult Index()
        {
            List<Employee> STEList = dBHelper.AllEmployees();
            return View(STEList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(string id)
        {
            Employee st = dBHelper.GetEmployee(id);
            return View(st);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string stID = collection["txtEMPLOYEE_ID"];
                string name = collection["txtEMPLOYEE_NAME"];
                string Surname = collection["txtEMPLOYEE_SURNAME"];
                string Email = collection["txtEMPLOYEE_EMAIL"];
                string password = collection["txtEMPLOYEE_PASSWORDS"];
                Employee st = new Employee(stID, name, Surname, Email, password);
                dBHelper.AddEmployee(st);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //// POST: Employee/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////public ActionResult Edit(string id, IFormCollection collection)
        //{
        //    try
        //    {
                
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Employee/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
