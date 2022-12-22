using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class HomeController : Controller
    {
        MVCCRUDBDcontext _context = new MVCCRUDBDcontext();
        public ActionResult Index()
        {
            var listofData = _context.Tables.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Table model)
        {
            _context.Tables.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Inserted successfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Tables.Where(x => x.Student_Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Table Model)
        {
            var data = _context.Tables.Where(x=> x.Student_Id == Model.Student_Id).FirstOrDefault();    
            if(data != null)
            {
                data.Student_Name = Model.Student_Name;
                data.Student_Fees = Model.Student_Fees;
                data.Student_Location = Model.Student_Location;
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = _context.Tables.Where(x=> x.Student_Id == id).FirstOrDefault();
            return View(data);
        }
      
        public ActionResult Delete(int id)
        {
            var data = _context.Tables.Where(x => x.Student_Id == id).FirstOrDefault();
            _context.Tables.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record deleted successfully";
            return RedirectToAction("index");
        }

    }
}