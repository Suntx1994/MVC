using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class PeopleService : IPeopleService
    {
        protected IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            this._peopleRepository = peopleRepository;
        }
        public IEnumerable<People> GetAllPeople()
        {
            //throw new NotImplementedException();
            return _peopleRepository.GetAll();
        }

        public People GetByFirstName(string firstname)
        {
            //throw new NotImplementedException();
            return _peopleRepository.GetByFirstName(firstname);
        }

        public People GetByLastName(string lastname)
        {
            //throw new NotImplementedException();
            return _peopleRepository.GetByLastName(lastname);
        }
    }

    public interface IPeopleService
    {
        IEnumerable<People> GetAllPeople();

        People GetByFirstName(string firstname);

        People GetByLastName(string lastname);
    }
}
