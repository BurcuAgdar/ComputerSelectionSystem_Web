using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class RAMService : IRAMService
    {
        private IRepository<RAM> ramrepository;

        public RAMService(IRepository<RAM> ramrepository)
        {
            this.ramrepository = ramrepository;
        }
        public void DeleteRAM(string id)
        {
            RAM ram = ramrepository.Get(id);
            ramrepository.Remove(ram);
            ramrepository.SaveChanges();
        }

        public RAM GetRAM(string id)
        {
            return ramrepository.Get(id);
        }

        public IEnumerable<RAM> GetRAMs()
        {
            return ramrepository.GetAll();
        }

        public void InsertRAM(RAM item)
        {
            ramrepository.Insert(item);
        }

        public void UpdateRAM(RAM item)
        {
            ramrepository.Update(item); 
        }
    }
}
