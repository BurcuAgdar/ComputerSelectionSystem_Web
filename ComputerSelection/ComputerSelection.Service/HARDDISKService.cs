using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class HARDDISKService : IHARDDISKService
    {
        private IRepository<HardDisk> harddiskrepository;

        public HARDDISKService(IRepository<HardDisk> harddiskrepository)
        {
            this.harddiskrepository = harddiskrepository;
        }
        public void DeleteHARDDISK(string id)
        {
            HardDisk harddisk = harddiskrepository.Get(id);
            harddiskrepository.Remove(harddisk);
            harddiskrepository.SaveChanges();
        }

        public HardDisk GetHARDDISK(string id)
        {
            return harddiskrepository.Get(id);
        }

        public IEnumerable<HardDisk> GetHARDDISKs()
        {
            return harddiskrepository.GetAll();
        }

        public void InsertHARDDISK(HardDisk item)
        {
            harddiskrepository.Insert(item);
        }

        public void UpdateHARDDISK(HardDisk item)
        {
            harddiskrepository.Update(item);
        }
    }
}
