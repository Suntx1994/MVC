using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contoso.Model;
using Contoso.Data;
using Contoso.Service;
using System.Linq;
using Moq;
using System.Collections.Generic;

namespace Contoso.Web.Tests.Service
{
    [TestClass]
    public class CoursesServiceTest
    {
        private ICourseService _courseService;
        private Mock<ICoursesRepository> _mockrepo;
        private List<Course> _mockdata;


        [TestInitialize]
        public void CheckCourseByMockingInitial()
        {
            _mockrepo = new Mock<ICoursesRepository>();
            _courseService = new CourseService(_mockrepo.Object);
            _mockdata = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Title = "Embedded System",
                    DepartId = 1,
                },
                new Course
                {
                    Id = 2,
                    Title = "Algorithm",
                    DepartId = 1,
                },
                new Course
                {
                    Id = 3,
                    Title = "machine learning",
                    DepartId = 2
                },
                new Course
                {
                    Id = 4,
                    Title = "Operating System",
                    DepartId = 1,
                }
                
            };
            _mockrepo.Setup(x => x.GetById(It.IsAny<int>())).Returns((int s) => _mockdata.First(x => x.Id == s));
            _mockrepo.Setup(x => x.GetAll()).Returns(_mockdata.ToList());
        }

        [TestMethod]
        public void CheckMockingCourseById()
        {
            var result = _courseService.GetById(1);

            Assert.IsNotNull(result);

            Assert.AreSame(_mockdata.Where(x => x.Id == 1).FirstOrDefault(), result);

        }

        [TestMethod]

        public void CheckMockingCourseGetAll()
        {
            var result = _courseService.GetAll();

            Assert.IsNotNull(result);

            Assert.AreEqual(4, result.Count());
        }
    }
}
