using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Enrollment
    {
        public int Id { get; set; }

       
        public int CourseId { get; set; }

        
        public int StudentId { get; set; }

        public string Grade { get; set; }

        public Student Students { get; set; }

        public Course Courses { get; set; }

    }
}
