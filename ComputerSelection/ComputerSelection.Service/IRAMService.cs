using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface IRAMService
    {
        IEnumerable<RAM> GetRAMs();
        RAM GetRAM(string id);
        void InsertRAM(RAM item);
        void UpdateRAM(RAM item);
        void DeleteRAM(string id);
    }
}
