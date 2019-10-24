using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Model;

namespace Contoso.Web.Controllers
{
//    public class PeopleController : Controller
//    {
//        // GET: People

//        private PeopleService _peopleService;
//        public PeopleController()
//        {
//            _peopleService = new PeopleService();
//        }
//        public ActionResult Index()
//        {
//            var peoples = _peopleService.GetAllPeople();
//            return View(peoples);
//        }

//        //public ActionResult GetAll()
//        //{
//        //    var peoples = _peopleService.GetAllPeople();
//        //    return View(peoples);
//        //}


//        [HttpGet]
//        public ActionResult AddPeople()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult AddPeople(People people)
//        {
//            _peopleService.AddPeople(people);
//            return RedirectToAction("Index");
//        }



//        [HttpGet]
//        public ActionResult EditPeople(int id)
//        {
//            var departments = _peopleService.GetPeopleById(id);
//            return View(departments);
//        }

//        [HttpPost]
//        public ActionResult EditPeople(People p)
//        {
//            _peopleService.UpdatePeople(p);
//            return RedirectToAction("Index");
//        }
//    }
}