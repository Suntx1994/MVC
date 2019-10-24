using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contoso.Service;
using Contoso.Model;

namespace Contoso.API.Controllers
{
    //MVC and API inherit from different class
    //mvc inherit from controller 
    //api inherit from apicontroller


        [RoutePrefix("api/departments")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }

        //method 
        //using Newtonsoft.json to change IEnumerable to json 
        [HttpGet]
        [Route("")]
        public IEnumerable<Depart> GetDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            return departments;
        }

        //HttpResponseMessage 
        //IHTTPAction
        [HttpGet]
        [Route("{id}")]
        
        public IHttpActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            if(department == null)
            {
                var response = Request.CreateResponse(HttpStatusCode.NotFound,"No department found");
                return ResponseMessage(response);
            }
            //return department;
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, department));
        }
    }
}
