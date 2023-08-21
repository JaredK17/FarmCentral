using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ST10090287_ProgPart2.Models;
using ST10090287_ProgPart2.FData;
using Microsoft.Extensions.Configuration;

namespace ST10090287_ProgPart2.Controllers
{
    public class ProductController : Controller
    {
        DBFarmer dBHelping;

        public ProductController(IConfiguration config)
        {
            dBHelping = new DBFarmer(config);
        }
        public ActionResult Index()
        {
            string farmerID = HttpContext.Session.GetString("FARMER_ID");
        List<Product> STPList = dBHelping.AllProducts(farmerID);
        return View(STPList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(string id)
        {
            Product st = dBHelping.GetProduct(id);
            return View(st);

           
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string stID = collection["txtPRODUCT_ID"];
                string type = collection["txtPRODUCT_TYPE"];
                string PP = collection["txtPRODUCT_PRICE"];
                string qty = collection["txtPRODUCT_QTY"];
                string fid = collection["txtFARMER_ID"];

                Product st = new Product(stID, type, PP, qty, fid);
                dBHelping.AddProduct(st);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(string id)
        {
            Product st1 = dBHelping.GetProduct(id);

            return View(st1);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
               
                string TYPE = collection["txtPRODUCT_TYPE"];
                string PRICE = collection["txtPRODUCT_PRICE"];
                string QTY = collection["txtPRODUCT_QTY"];
                string FID = collection["txtFARMER_ID"];
                Product st1 = new Product(id, TYPE, PRICE, QTY, FID);
                dBHelping.updateProduct(id, st1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(string id)
        {
            Product st1 = dBHelping.GetProduct(id);
            return View(st1);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                dBHelping.deleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
