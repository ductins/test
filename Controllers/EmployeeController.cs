using DAHQTCSDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DAHQTCSDL.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: NhanVien
        MyDBContext db = new MyDBContext();
        public ActionResult Index()
        {
           
            List<Employee> emp = db.Employees.ToList();
            return View(emp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp) 
        {
            if (ModelState.IsValid) 
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }
        public ActionResult Update(int id)
        {
            Employee emp = db.Employees.Where(t => t.manv == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Update(Employee emp,int id)
        {
            if (ModelState.IsValid)
            {
                Employee E = db.Employees.Where(t => t.manv == id).FirstOrDefault();
                E.tennv = emp.tennv;
                E.ngaysinh = emp.ngaysinh;
                E.diachi = emp.diachi;
                E.sdt = emp.sdt;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
           
        }
        public ActionResult Delete(int id)
        {
            Employee emp = db.Employees.Where(t => t.manv == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(Employee emp, int id)
        {
            if (ModelState.IsValid)
            {
                Employee E = db.Employees.Where(t => t.manv == id).FirstOrDefault();            
                db.Employees.Remove(E);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }

        }
    }
}