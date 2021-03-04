using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface ICPUService
    {
        IEnumerable<CPU> GetCPUs();
        CPU GetCPU(string id);
        void InsertCPU(CPU item);
        void UpdateCPU(CPU item);
        void DeleteCPU(string id);
        CPU GetContains(string id);

    }
}
