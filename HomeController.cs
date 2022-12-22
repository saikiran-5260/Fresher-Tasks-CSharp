using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDB.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBcontext _context = new EmployeeDBcontext();
        public ActionResult Index()
        {
            var listofData = _context.Employees.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(employee != null)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                ViewBag.Message = "Created successfully";
                
            }
            return View();


        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Employees.Where(y=> y.Employee_Id== id).FirstOrDefault();
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(Employee Employee)
        {
            var data = _context.Employees.Where(y => y.Employee_Id == Employee.Employee_Id).FirstOrDefault();
            if(data!=null)
            {
                data.Employee_name = Employee.Employee_name;
                data.Employee_Location = Employee.Employee_Location;
                data.Employee_MobileNum = Employee.Employee_MobileNum;
                data.Employee_Designation = Employee.Employee_Designation;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var data = _context.Employees.Where(y => y.Employee_Id == id).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.Employee_Id == id).FirstOrDefault();
            _context.Employees.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record deleted successfully";
            return RedirectToAction("Index");
        }

      
    }
}