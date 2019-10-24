using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        protected ICoursesRepository _CoursesRepository;

        public CourseService(ICoursesRepository coursesRepository)
        {
            this._CoursesRepository = coursesRepository;
        }
        public IEnumerable<Course> GetAll()
        {
            //throw new NotImplementedException();
            return _CoursesRepository.GetAll();
        }

        public Course GetById(int id)
        {
            //throw new NotImplementedException();
            return _CoursesRepository.GetById(id);
        }

        public Course GetByTitle(string title)
        {
            //throw new NotImplementedException();
            return _CoursesRepository.GetByTitle(title);
        }
    }

    public interface ICourseService
    {
        IEnumerable<Course> GetAll();

        Course GetById(int id);

        Course GetByTitle(string title);
    }
}
