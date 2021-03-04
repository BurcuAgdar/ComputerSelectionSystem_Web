using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class CPUService : ICPUService
    {
        private IRepository<CPU> cpurepository;

        public CPUService(IRepository<CPU> cpurepository)
        {
            this.cpurepository = cpurepository;
        }

        public void DeleteCPU(string id)
        {
            CPU cpu = cpurepository.Get(id);
            cpurepository.Remove(cpu);
            cpurepository.SaveChanges();
        }

        public CPU GetCPU(string id)
        {
            return cpurepository.Get(id);
        }
        public IEnumerable<CPU> GetCPUs()
        {
            return cpurepository.GetAll();
        }

        public void InsertCPU(CPU item)
        {
            cpurepository.Insert(item);
        }

        public void UpdateCPU(CPU item)
        {
            cpurepository.Update(item);
        }
     
        public CPU GetContains(string id)
        {
           IEnumerable<CPU> cpulist = cpurepository.GetAll();
            CPU Cp = cpurepository.Get(id);
            if (Cp!=null){
                return Cp;
            }
            else
            {
                foreach (CPU item in cpulist)
                {

                    if (item.Model.Contains(id) || id.Contains(item.Model))
                    {
                        return item;
                    }

                }
            }
               
           
            return null;

        }
    }
}
