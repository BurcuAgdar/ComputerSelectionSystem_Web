using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        void Remove(T item);
        T GetContains(string id);
        void SaveChanges();
    }
}
