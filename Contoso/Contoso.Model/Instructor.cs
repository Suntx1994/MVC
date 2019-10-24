using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    [Table("Instuctors")]
    public class Instructor:People
    {
        public DateTime HiredDate { get; set; }

        public ICollection<Depart> Departs { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
