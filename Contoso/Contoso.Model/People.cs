using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    [Table("People")]
    public class People
    {
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public Nullable<int> Phone { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public Nullable<int> UnitOrApartmentNumber { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public Nullable<int> ZipCode { get; set; }

        public string PassWord { get; set; }

        public string Salt { get; set; }

        public Boolean IsLocked { get; set; }

        public Nullable<DateTime> LastLockedDateTime { get; set; }

        public Nullable<int> FailedAttempts { get; set; }

        public Nullable<DateTime> CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string  UpdatedBy { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
