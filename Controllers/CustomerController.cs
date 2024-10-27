using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAHQTCSDL.Models;

namespace DAHQTCSDL.Controllers
{
    public class CustomerController : Controller
    {
        // GET: KhachHang
        MyDBContext db = new MyDBContext();
        public ActionResult Index()
        {
           
            List<Customer> kh=db.Customers.ToList();
            return View(kh);
        }
        public ActionResult Create()
        {
       
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
           
           
                if (ModelState.IsValid)
                {
                    db.Customers.Add(cus);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return View(cus);
        }
        public ActionResult Update(int id=0)
        {
           Customer cus=db.Customers.Where(t=>t.makh==id).FirstOrDefault();
           return View(cus);
        }
        [HttpPost]
        public ActionResult Update(Customer cus,int id)
        {
            if (ModelState.IsValid) 
            { 
                Customer C= db.Customers.Where(t=>t.makh==id).FirstOrDefault();
                C.tenkh=cus.tenkh;
                C.diachikh=cus.diachikh;
                C.sdtkh=cus.sdtkh;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            { 
                return View(cus); 
            }
        }
        public ActionResult Delete(int id) 
        {
            Customer cus = db.Customers.Where(t => t.makh == id).FirstOrDefault();
            return View(cus);
        }
        [HttpPost]
        public ActionResult Delete(Customer cus, int id)
        {
            if (ModelState.IsValid)
            {
                Customer C=db.Customers.Where(t=>t.makh==id).FirstOrDefault();
                db.Customers.Remove(C);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(cus);
        }
    }
}