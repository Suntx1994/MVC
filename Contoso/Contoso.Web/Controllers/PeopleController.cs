using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Model;

namespace Contoso.Web.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        private IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this._peopleService = peopleService;
        }
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllPeople()
        {
            var result = _peopleService.GetAllPeople();
            return View(result);
        }

        

        public ActionResult GetByFirstName()
        {
            string name = Request.Form["FirstName"];
            var result = _peopleService.GetByFirstName(name);
            return View(result);
        }

    }
}