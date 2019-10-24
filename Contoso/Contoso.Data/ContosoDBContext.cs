using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoDBContext:DbContext
    {
        public ContosoDBContext():base("name = ContosoMVC")
        {

        }

        public DbSet<People> Peoples { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<OfficeAssignments> OfficeAssignments { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Depart> Departs { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
