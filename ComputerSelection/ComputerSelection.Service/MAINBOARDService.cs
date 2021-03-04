using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class MAINBOARDService : IMAINBOARDService
    {
        private IRepository<MainBoard> mainboardrepository;

        public MAINBOARDService(IRepository<MainBoard> mainboardrepository)
        {
            this.mainboardrepository = mainboardrepository;
        }
        public void DeleteMAINBOARD(string id)
        {
            MainBoard mainboard = mainboardrepository.Get(id);
            mainboardrepository.Remove(mainboard);
            mainboardrepository.SaveChanges();
        }

        public MainBoard GetMAINBOARD(string id)
        {
            return mainboardrepository.Get(id);
        }

        public IEnumerable<MainBoard> GetMAINBOARDs()
        {
            return mainboardrepository.GetAll();
        }

        public void InsertMAINBOARD(MainBoard item)
        {
            mainboardrepository.Insert(item);
        }

        public void UpdateMAINBOARD(MainBoard item)
        {
            mainboardrepository.Update(item);
        }
    }
}
