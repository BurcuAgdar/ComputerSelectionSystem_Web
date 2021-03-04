using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface IMAINBOARDService
    {
        IEnumerable<MainBoard> GetMAINBOARDs();
        MainBoard GetMAINBOARD(string id);
        void InsertMAINBOARD(MainBoard item);
        void UpdateMAINBOARD(MainBoard item);
        void DeleteMAINBOARD(string id);
    }
}
