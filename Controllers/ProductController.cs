using CRUDUsingEF1.Data;
using CRUDUsingEF1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUsingEF1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        ProductDAL productdal;
        public ProductController(ApplicationDbContext Context)
        {
            this.context = context;
            productdal = new ProductDAL(context);
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var p = productdal.GetAllProducts();
            return View(p);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var p = productdal.GetProductById(id);
            return View(p);
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var p = productdal.GetProductById(id);
            return View(p);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var p = productdal.GetProductById(id);
            return View(p);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, IFormCollection collection)
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
