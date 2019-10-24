using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model;

namespace Contoso.Data
{
    public class departRepository : Repository<Depart>, IDepartmentRepository
    {
        public departRepository(ContosoDBContext context) : base(context)
        {
        }

        public Depart GetDepartmentByName(string name)
        {
            //throw new NotImplementedException();
            var department = _dbContext.Departs.FirstOrDefault(d => d.Name == name);
            return department;
        }
    }


    public interface IDepartmentRepository: Contoso.Data.IRepository<Depart>
    {
        Depart GetDepartmentByName(string name);
    }
}
