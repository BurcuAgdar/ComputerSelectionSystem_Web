using ComputerSelection.Data;
using ComputerSelection.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Service
{
    public class ComputerService : IComputerService
    {
        private IRepository<Computers> computerrepository;
        public ComputerService(IRepository<Computers> computerrepository)
        {
            this.computerrepository = computerrepository;
        }
        public void DeleteComputer(string id)
        {
            Computers com = computerrepository.Get(id);
            computerrepository.Remove(com);
            computerrepository.SaveChanges();
        }

        public Computers GetComputer(string id)
        {
            return computerrepository.Get(id);
        }

        public IEnumerable<Computers> GetComputers()
        {
            return computerrepository.GetAll();
        }

        public void InsertComputer(Computers item)
        {
            computerrepository.Insert(item);
        }

        public void UpdateComputer(Computers item)
        {
            computerrepository.Update(item);
        }
    }
}
