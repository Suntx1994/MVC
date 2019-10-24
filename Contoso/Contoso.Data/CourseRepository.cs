using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class CoursesRepository : Repository<Course>, ICoursesRepository
    {
        public CoursesRepository(ContosoDBContext context):base(context)
        {

        }

        public Course GetByTitle(string name)
        {
            //throw new NotImplementedException();
            return _dbContext.Courses.Where(c => c.Title == name).FirstOrDefault();
        }
    }

//{
//    public class CourseRepository : IRepository<Course>
//    {

//        public void Create(Course c)
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDBContext())
//            {
//                db.Courses.Add(c);
//                db.SaveChanges();
//            }

//        }

//        public IEnumerable<Course> GetAll()
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDBContext())
//            {
//                return db.Courses.ToList();
//            }
//        }

//        public Course GetById(int id)
//        {
//            //throw new NotImplementedException();
//            using(var db = new ContosoDBContext())
//            {
//                return db.Courses.Where(c => c.Id == id).SingleOrDefault();
//            }
//        }

//        public Course GetByName(string Name)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Course c)
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDBContext())
//            {
//                var coursebyid = db.Courses.Where(x => x.Id == c.Id).SingleOrDefault();
//                coursebyid.Title = c.Title;
//                coursebyid.Credits = c.Credits;
//                coursebyid.DepartId = c.DepartId;
//                db.SaveChanges();
//            }
//        }
//    }

    public interface ICoursesRepository:IRepository<Course>
    {
        Course GetByTitle(string name);
    }
}
