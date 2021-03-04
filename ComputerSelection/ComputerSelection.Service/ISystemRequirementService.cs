using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Data;

namespace ComputerSelection.Service
{
    public interface ISystemRequirementService
    {
        IEnumerable<SystemRequirement> GetSystemRequirements();
        SystemRequirement GetSYSTEMREQUIRMENT(string id);
        void InsertSYSTEMREQUIRMENT(SystemRequirement item);
        void UpdateSYSTEMREQUIRMENT(SystemRequirement item);
        void DeleteSYSTEMREQUIRMENT(string id);
    }
}
