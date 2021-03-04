using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface ISSDService
    {
        IEnumerable<SSD> GetSSDs();
        SSD GetSSD(string id);
        void InsertSSD(SSD item);
        void UpdateSSD(SSD item);
        void DeleteSSD(string id);
    }


}
