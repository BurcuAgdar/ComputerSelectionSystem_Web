using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface IGPUService
    {
        IEnumerable<GPU> GetGPUs();
        GPU GetGPU(string id);
        void InsertGPU(GPU item);
        void UpdateGPU(GPU item);
        void DeleteGPU(string id);
        GPU GetContains(string id);
    }
}
