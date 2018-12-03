using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversalProbiotic.Models;
using System.Data.Entity;
using System.IO;

namespace UniversalProbiotic.Controllers
{
    public class HomeController : Controller
    {
        public ModelContext db = new ModelContext();
        public ActionResult Index()
        {
            var list = db.Products.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn more about Universal Probiotics";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ViewAllProducts()
        {
            List<Product> list = db.Products.ToList();
            return View(list);
        }


        public ActionResult ViewSingleProduct(int id)
        {
            Product p = db.Products.First();
            switch (id)
            {
                case 1:
                    p = db.Products.Where(m => m.Species.Equals("Canine")).FirstOrDefault();
                    break;
                case 2:
                    p = db.Products.Where(m => m.Species.Equals("Feline")).FirstOrDefault();
                    break;
                case 3:
                    p = db.Products.Where(m => m.Species.Equals("Doe")).FirstOrDefault();
                    break;
                case 4:
                    p = db.Products.Where(m => m.Species.Equals("Equine")).FirstOrDefault();
                    break;
                case 5:
                    p = db.Products.Where(m => m.Species.Equals("Poultry")).FirstOrDefault();
                    break;
                case 6:
                    p = db.Products.Where(m => m.Species.Equals("Swine")).FirstOrDefault();
                    break;
                default:
                    p = db.Products.Where(m => m.Species.Equals("Bovine")).FirstOrDefault();
                    break;
            }
            
            return View(p);
        }

        [HttpGet]
        public ActionResult UploadImages(int id)
        {
            Product p = db.Products.Find(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult UploadImages(Product product, HttpPostedFileBase image)
        {
            Product p = db.Products.Find(product.ProductID);
            if (ModelState.IsValid)
            {
                if(image != null)
                {
                    p.PictureType = image.ContentType;
                    p.PictureData = new byte[image.ContentLength];
                    image.InputStream.Read(p.PictureData, 0, image.ContentLength);
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }

        public FileContentResult GetImage(int id)
        {
            var item = db.Products.Find(id);
            return File(item.PictureData, item.PictureType);

        }


    }
}