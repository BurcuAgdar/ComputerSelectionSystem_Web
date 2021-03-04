using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Service
{
    public interface IComputerService
    {
        IEnumerable<Computers> GetComputers();
        Computers GetComputer(string id);
        void InsertComputer(Computers item);
        void UpdateComputer(Computers item);
        void DeleteComputer(string id);
    }
}
