using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contoso.Model;
using Contoso.Data;
using Contoso.Service;
using Moq;
using System.Linq;
using System.Collections.Generic;

namespace Contoso.Web.Tests.Service
{
    [TestClass]
    public class PeopleServiceTest
    {
        private Mock<IPeopleRepository> _peoplerepository;
        private IPeopleService _peopleService;
        private List<People> _mockdata;

        [TestInitialize]
        public void MockingInit()
        {
            _peoplerepository = new Mock<IPeopleRepository>();
            _peopleService = new PeopleService(_peoplerepository.Object);
            _mockdata = new List<People>
            {
                new People
                {
                    Id = 1,
                    FirstName = "Wu",
                    LastName = "Wang"
                },
                new People
                {
                    Id = 2,
                    FirstName = "San",
                    LastName = "Zhang"
                },
                new People
                {
                    Id = 3,
                    FirstName = "Si",
                    LastName = "Li"
                },
                new People
                {
                    Id = 4,
                    FirstName = "Qi",
                    LastName = "Zhou"
                }
            };
            _peoplerepository.Setup(x => x.GetAll()).Returns(_mockdata);
        }


        [TestMethod]
        public void CheckMockGetAllPEople()
        {
            var allpeoples = _peopleService.GetAllPeople();
            Assert.IsNotNull(allpeoples);
            Assert.AreEqual(4, allpeoples.Count());
            //Assert.AreSame(_mockdata, allpeoples.ToList());
        }

        public void CheckMockGetByFirstName()
        {
            var peoplebyfirstname = _peopleService.GetByFirstName("Sun");
            Assert.IsNotNull(peoplebyfirstname);
            Assert.AreSame(_mockdata.Where(x => x.FirstName == "Sun").FirstOrDefault(), peoplebyfirstname);
        }
    }
}
