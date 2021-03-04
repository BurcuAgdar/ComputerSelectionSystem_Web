using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerSelection.Repository;

namespace ComputerSelection.Service
{
    public class GPUService:IGPUService
    {
        private IRepository<GPU> gpurepository;

        public GPUService(IRepository<GPU> gpurepository)
        {
            this.gpurepository = gpurepository;
        }

        public void DeleteGPU(string id)
        {
            GPU gpu = gpurepository.Get(id);
            gpurepository.Remove(gpu);
            gpurepository.SaveChanges();
        }

        public GPU GetGPU(string id)
        {
            return gpurepository.Get(id);
        }

        public IEnumerable<GPU> GetGPUs()
        {
            return gpurepository.GetAll();
        }
        public GPU GetContains(string id)
        {
            IEnumerable<GPU> gpulist = gpurepository.GetAll();
            GPU Gp = gpurepository.Get(id);
            if (Gp != null)
            {
                return Gp;
            }
            else
            {
                foreach (GPU item in gpulist)
                {

                    if (item.Model.Contains(id) || id.Contains(item.Model))
                    {
                        return item;
                    }

                }
            }


            return null;

        }

        public void InsertGPU(GPU item)
        {
            gpurepository.Insert(item);
        }

        public void UpdateGPU(GPU item)
        {
            gpurepository.Update(item);
        }
    }
}
