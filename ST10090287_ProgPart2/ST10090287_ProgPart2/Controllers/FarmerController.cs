using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ST10090287_ProgPart2.FData;
using ST10090287_ProgPart2.Models;
using System.Collections.Generic;

namespace ST10090287_ProgPart2.Controllers
{
    public class FarmerController : Controller
    {
        DBFarmer dBHelp;
        public FarmerController(IConfiguration config)
        {
            dBHelp = new DBFarmer(config);
        }
        public ActionResult Index()
        {
            List<Farmers> stList = dBHelp.AllFarmers();
            return View(stList);
        }


        // GET: Farmer/Details/5
        public ActionResult Details(string id)
        {
            Farmers st = dBHelp.GetFarmers(id);
            return View(st);
        }

        // GET: Farmer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string stID = collection["txtFARMER_ID"];
                string name = collection["txtFARMER_NAME"];
                string Surname = collection["txtFARMER_SURNAME"];
                string Email = collection["txtFARMER_EMAIL"];
                string password = collection["FARMER_PASSWORD"];
                Farmers st = new Farmers(stID, name, Surname, Email, password);
                dBHelp.AddFarmer(st);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
               
                return View();
            }
        }

        // GET: Farmer/Edit/5
        public ActionResult Edit(string id)
        {
            Farmers stt = dBHelp.GetFarmers(id);
            return View(stt);
        }

        // POST: Farmer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {

                string name = collection["txtName"];
                string surname = collection["txtSurname"];
                string mail = collection["txtEmail"];
                string pass = collection["txtPassword"];
                Farmers stt = new Farmers(id, name, surname, mail, pass);
                dBHelp.UpdateFarmer(id, stt);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Farmer/Delete/5
        public ActionResult Delete(string id)
        {
            Farmers stt = dBHelp.GetFarmers(id);
            return View(stt);
        }

        // POST: Farmer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                dBHelp.DeleteFarmer(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ProductsPage()
        {
            List<Product> stList = dBHelp.FAllProducts();
            return View(stList);
        }
    }


}

