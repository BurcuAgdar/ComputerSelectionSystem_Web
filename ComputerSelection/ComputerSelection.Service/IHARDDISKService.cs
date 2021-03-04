using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface IHARDDISKService
    {
        IEnumerable<HardDisk> GetHARDDISKs();
        HardDisk GetHARDDISK(string id);
        void InsertHARDDISK(HardDisk item);
        void UpdateHARDDISK(HardDisk item);
        void DeleteHARDDISK(string id);
    }
}
