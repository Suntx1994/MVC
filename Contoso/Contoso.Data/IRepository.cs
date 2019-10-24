using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T>where T:class
    {
        // T GetById(int id);

        // IEnumerable<T> GetAll();

        // T GetByName(string Name);

        //// decimal GetByMax();

        // void Create(T c);

        // void Update(T c);

        // void Delete(T entity);

        // void Delete(Expression<Func<T, bool>> where);

        // T Get(Expression<Func<T, bool>> where);

        // IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        // int GetCount(Expression<Func<T, bool>> filter = null);

        // void SaveChanges();

        void Add(T entity);
        // Marks an entity as modified
        void Update(T entity);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        // Get an entity by int id
        T GetById(int id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        int GetCount(Expression<Func<T, bool>> filter = null);
        // Saving the changes to Database
        void SaveChanges();
    }
}
