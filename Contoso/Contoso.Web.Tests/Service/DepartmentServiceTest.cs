using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;//Assert comes from 
using Contoso.Data;
using Contoso.Model;
using Contoso.Service;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Moq;
//MS Test for unit test
//two more popular Nunit and Xunit

namespace Contoso.Web.Tests.Service
{
    [TestClass]
    public class DepartmentServiceTest
    {
        private IDepartmentService _departmentService;
        private Mock<IDepartmentRepository> _mockdepartmentrepository;
        //initial the instance once
        private List<Depart> _departments;
        

        [TestInitialize]
        public void Initialize()
        {
            _mockdepartmentrepository = new Mock<IDepartmentRepository>();
            _departmentService = new DepartmentService(_mockdepartmentrepository.Object);
            //initial the mock data
            _departments = new List<Depart>
            {
                new Depart
                {
                    Id = 1,
                    Name = "Depart1",
                    Budget = 3000,
                    StartDate = DateTime.Now
                },

                new Depart
                {
                    Id =2 ,
                    Name = "Depart2",
                    Budget = 4000,
                    StartDate = DateTime.Now

                },

                new Depart
                {
                    Id =3 ,
                    Name = "Depart3",
                    Budget = 9000,
                    StartDate = DateTime.Now

                },

                new Depart
                {
                    Id =4 ,
                    Name = "Depart4",
                    Budget = 7000,
                    StartDate = DateTime.Now

                },
            };
            _mockdepartmentrepository.Setup(d => d.GetAll()).Returns(_departments);
            _mockdepartmentrepository.Setup(x => x.GetById(It.IsAny<int>())).Returns((int s) => _departments.First(x => x.Id == s));
        }

        [TestMethod]
        public void CheckDepartmentGetByIdFakeData()
        {
            var result = _departmentService.GetDepartmentById(2);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Id);
            Assert.AreSame(_departments.Where(x => x.Id == 2).FirstOrDefault(), result);
        }

        [TestMethod]
        public void CheckDepartmentCountFromFakeData() //name should be explained itself
        {

            //_departmentService = new DepartmentService(new MockDepartmentRepository());

            var departments = _departmentService.GetAllDepartments();
            //AAA
            //Arrange (creating fake data and mock objects or instances)
            //Act (invoking the methods and properties)
            //Assert (Varify the action of method, make sure it behaves as expected)

            Assert.IsNotNull(departments);
            Assert.AreEqual(4, departments.Count());
        }
    }


    //public class MockDepartmentRepository : IDepartmentRepository
    //{
    //    public void Add(Depart entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Depart entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Expression<Func<Depart, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Depart Get(Expression<Func<Depart, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Depart> GetAll()
    //    {
    //        //throw new NotImplementedException();
    //        var departments = new List<Depart>
    //        {
    //            new Depart
    //            {
    //                Id = 1,
    //                Name = "Depart1",
    //                Budget = 3000,
    //                StartDate = DateTime.Now
    //            },

    //            new Depart
    //            {
    //                Id =2 ,
    //                Name = "Depart2",
    //                Budget = 4000,
    //                StartDate = DateTime.Now

    //            },

    //            new Depart
    //            {
    //                Id =3 ,
    //                Name = "Depart3",
    //                Budget = 9000,
    //                StartDate = DateTime.Now

    //            },

    //            new Depart
    //            {
    //                Id =4 ,
    //                Name = "Depart4",
    //                Budget = 7000,
    //                StartDate = DateTime.Now

    //            },
    //        };

    //        return departments;
    //    }

    //    public Depart GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int GetCount(Expression<Func<Depart, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Depart GetDepartmentByName(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Depart> GetMany(Expression<Func<Depart, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveChanges()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Depart entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
