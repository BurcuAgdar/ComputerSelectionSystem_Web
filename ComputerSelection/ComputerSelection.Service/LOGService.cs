using ComputerSelection.Data;
using ComputerSelection.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Service
{
    public class LOGService : ILogService
    {
        private IRepository<Log> logrepository;
        public LOGService(IRepository<Log> logrepository)
        {
            this.logrepository = logrepository;
        }
        public void DeleteLog(string id)
        {
            Log l = logrepository.Get(id);
            logrepository.Remove(l);
            logrepository.SaveChanges();
        }

        public Log GetLog(string id)
        {
            return logrepository.Get(id);
        }

        public IEnumerable<Log> GetLogs()
        {
            return logrepository.GetAll();
        }

        public void InsertLog(Log item)
        {
            logrepository.Insert(item);
        }

        public void UpdateLog(Log item)
        {
            logrepository.Update(item);
        }
    }
}
