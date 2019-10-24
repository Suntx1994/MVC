using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;


namespace Contoso.Data
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {

        public PeopleRepository(ContosoDBContext context):base(context)
        {

        }
        public People GetByFirstName(string firstname)
        {
            //throw new NotImplementedException();
            return _dbContext.Peoples.Where(p => p.FirstName == firstname).FirstOrDefault();
        }

        public People GetByLastName(string Lastname)
        {
            //throw new NotImplementedException();
            return _dbContext.Peoples.Where(p => p.LastName == Lastname).FirstOrDefault();
        }
    }

    public interface IPeopleRepository:IRepository<People>
    {
        People GetByFirstName(string firstname);

        People GetByLastName(string Lastname);

    }
}
