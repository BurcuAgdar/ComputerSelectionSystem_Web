using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Service
{
    public interface ILogService
    {
        IEnumerable<Log> GetLogs();
        Log GetLog(string id);
        void InsertLog(Log item);
        void UpdateLog(Log item);
        void DeleteLog(string id);
    }
}
