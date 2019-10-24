using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public ICollection<People> Peoples { get; set; }
    }
}
