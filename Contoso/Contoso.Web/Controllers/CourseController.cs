using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Model;

namespace Contoso.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course

        protected ICourseService _CourseService;
        public CourseController(ICourseService courseService)
        {
            this._CourseService = courseService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllCourses()
        {
            var allcourses = _CourseService.GetAll();
            return View(allcourses);
        }


        public ActionResult GetById(int id)
        {
            var CourseById = _CourseService.GetById(id);
            return View(CourseById);
        }
    }
}