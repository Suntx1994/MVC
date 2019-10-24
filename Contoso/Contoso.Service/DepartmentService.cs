using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
            //any class that implement this interface can be passed in
        {
            this._departmentRepository = departmentRepository;
        }
        public void CreateDepartment(Depart department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Depart> GetAllDepartments()
        {

            return _departmentRepository.GetAll();
        }

        public Depart GetDepartByName(string name)
        {
            return _departmentRepository.GetDepartmentByName(name);
        }

        public Depart GetDepartmentById(int id)
        {
            //throw new NotImplementedException();
            return _departmentRepository.GetById(id);
        }

        public int GetTotalDepartmentsCount()
        {
            //throw new NotImplementedException();
            return _departmentRepository.GetCount();
        }
    }

    public interface IDepartmentService
    {
        IEnumerable<Depart> GetAllDepartments();

        int GetTotalDepartmentsCount();

        Depart GetDepartmentById(int id);

        Depart GetDepartByName(string name);

        void CreateDepartment(Depart department);
    }
}
