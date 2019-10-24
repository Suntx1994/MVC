using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Model;
using Contoso.Web.Filter;

namespace Contoso.Web.Controllers
{
    //[HandleError]
    [ContosoExceptionFilter]
    public class DepartmentController : Controller
    {
        // GET: Department
        private readonly IDepartmentService _departmentservice;
        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentservice = departmentService;
        }

        
        public ActionResult Index()
        {

            //int i = 0; int x = 1;
            //int y = x / i;
            var departments = _departmentservice.GetAllDepartments();
            //ViewData["depts"] = departments;
            ViewBag.DepartmentCount = departments.Count();
            return View(departments); // return view in same folder with same name;

        }

        public ActionResult Max()
        {
            //var maxbudget = _departmentservice.GetMaxValue();
            //ViewBag.Max = maxbudget;
            return View();
        }


        public ActionResult ById()
        {

            //return View(departmentbyid);
            int id = Convert.ToInt32(Request.Form["Id"]);
            //var departmentbyname = _departmentservice.GetById(id);
            //return View(departmentbyname);
            return View();
        }

        //public ActionResult ByName()
        //{
        //    string name = Request.Form["Name"];
        //    var departmentbyname = _departmentservice.GetByName(name);
        //    return View(departmentbyname);
        //}


        [HttpPost]
        public ActionResult ByName()
        {
            string name = Request.Form["Name"];
            //return View();
            var departmentbyname = _departmentservice.GetDepartByName(name);
            return View(departmentbyname);
            
        }

        [HttpGet]
        [ActionName("ByName")]
        public ActionResult GetByName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddValue()
        {
            Depart department = new Depart();
            department.Name = Request.Form["Name"];
            department.Budget = Convert.ToDecimal(Request.Form["Budget"]);
            department.StartDate = Convert.ToDateTime(Request.Form["StartDate"]);
            department.InstructorId = Convert.ToInt32(Request.Form["InstructorId"]);
            department.RowVersion = Request.Form["RowVersion"];
            //_departmentservice.AddDepartment(department);
            return View();
        }
        [HttpGet]
        [ActionName("AddValue")]
        public ActionResult GetAddValue()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create2(Depart department)
        {
            //Get the data from formcollection and call service layer 
            //save to database
            //try
            //{
            //    var departname = form["departname"];
            //    var budget = form["budget"];
            //    var startdate = form["startdate"];

            //    Depart department = new Depart();
            //    department.Name = departname;
            //    department.Budget = Convert.ToDecimal(budget);
            //    department.StartDate = Convert.ToDateTime(startdate);
            //    department.InstructorId = 1;

            //    _departmentservice.AddDepartment(department);

            //    return RedirectToAction("Index");
            //}
            //catch (Exception)
            //{

            //    return View();
            //}
            try
            {
                department.InstructorId = 1;

                //_departmentservice.AddDepartment(department);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var department = _departmentservice.GetDepartmentById(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(Depart department)
        {
            //_departmentservice.UpdateDepartment(department);

            return RedirectToAction("Index");
        }
    }
}  