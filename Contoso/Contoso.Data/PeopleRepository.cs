using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;


namespace Contoso.Data
{
    //public class PeopleRepository : IRepository<People>
    //{
    //    public void Create(People p)
    //    {
    //        //throw new NotImplementedException();
    //        using (var db = new ContosoDBContext())
    //        {
    //            db.Peoples.Add(p);
    //            db.SaveChanges();
    //        }
    //    }

    //    public IEnumerable<People> GetAll()
    //    {
    //        //throw new NotImplementedException();
    //        using (var db = new ContosoDBContext())
    //        {
    //            return db.Peoples.ToList();
    //        }
    //    }

    //    public People GetById(int id)
    //    {
    //        //throw new NotImplementedException();
    //        using(var db = new ContosoDBContext())
    //        {
    //            return db.Peoples.Where(p => p.Id == id).SingleOrDefault();
    //        }
    //    }

    //    public People GetByName(string Name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(People p)
    //    {
    //        //throw new NotImplementedException();
    //        using (var db = new ContosoDBContext())
    //        {
    //            var peoplebyid = db.Peoples.Where(x => x.Id == p.Id).SingleOrDefault();
    //            peoplebyid.FirstName = p.FirstName;
    //            peoplebyid.LastName = p.LastName;
    //            peoplebyid.DateOfBirth = p.DateOfBirth;
    //            db.SaveChanges();
    //        }
    //    }
    //}
}
