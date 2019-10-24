using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public Depart Departs { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
    }
}
