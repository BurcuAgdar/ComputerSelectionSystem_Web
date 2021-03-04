using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class SSDService : ISSDService
    {
        private IRepository<SSD> ssdrepository;

        public SSDService(IRepository<SSD> ssdrepository)
        {
            this.ssdrepository = ssdrepository;
        }
        public void DeleteSSD(string id)
        {
            SSD ssd = ssdrepository.Get(id);
            ssdrepository.Remove(ssd);
            ssdrepository.SaveChanges();
        }

        public SSD GetSSD(string id)
        {
            return ssdrepository.Get(id);
        }

        public IEnumerable<SSD> GetSSDs()
        {
            return ssdrepository.GetAll();
        }

        public void InsertSSD(SSD item)
        {
            ssdrepository.Insert(item); ;
        }

        public void UpdateSSD(SSD item)
        {
            ssdrepository.Update(item);
        }
    }
}
