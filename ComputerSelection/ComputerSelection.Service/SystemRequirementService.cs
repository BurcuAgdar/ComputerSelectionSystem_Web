using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class SystemRequirementService : ISystemRequirementService
    {
        private IRepository<SystemRequirement> SystemRequirementrepository;

        public SystemRequirementService(IRepository<SystemRequirement> SystemRequirementrepository)
        {
            this.SystemRequirementrepository = SystemRequirementrepository;
        }
        public void DeleteSYSTEMREQUIRMENT(string id)
        {
            SystemRequirement SystemRequirement = SystemRequirementrepository.Get(id);
            SystemRequirementrepository.Remove(SystemRequirement);
            SystemRequirementrepository.SaveChanges();
        }

        public IEnumerable<SystemRequirement> GetSystemRequirements()
        {
            return SystemRequirementrepository.GetAll();
        }

        public SystemRequirement GetSYSTEMREQUIRMENT(string id)
        {
            return SystemRequirementrepository.Get(id);
        }

        public void InsertSYSTEMREQUIRMENT(SystemRequirement item)
        {
            SystemRequirementrepository.Insert(item);
        }

        public void UpdateSYSTEMREQUIRMENT(SystemRequirement item)
        {
            SystemRequirementrepository.Update(item);

        }
    }
}
