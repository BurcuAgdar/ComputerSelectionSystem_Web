using ComputerSelection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ComputerSelection.Service;
using ComputerSelection.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace ComputerSelection.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGPUService gpuService;

        public GPUController(IGPUService gpuService)
        {
            this.gpuService = gpuService;
        }
        [Authorize]
        [HttpGet]


        public IActionResult GPUList()
        {
            List<GPUViewModel> model = new List<GPUViewModel>();
            gpuService.GetGPUs().ToList().ForEach(u =>
            {
                GPU gpu = gpuService.GetGPU(u.Model);
                GPUViewModel gpuitem = new GPUViewModel
                {
                    Model = u.Model,
                    Company = u.Company,
                    GPUChip = u.GPUChip,
                    Released = u.Released,
                    Bus = u.Bus,
                    Memory = u.Memory,
                    GPUclock = u.GPUclock,
                    Memoryclock = u.Memoryclock,
                    Shaders_TMUs_ROPs = u.Shaders_TMUs_ROPs,
                    PassmarkG3dMark = u.PassmarkG3dMark,
                    Rank = u.Rank,

                };
                model.Add(gpuitem);
            });

            return View(model);
        }
        [Authorize]
        public IActionResult AddGPU()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddGPU(GPUViewModel mod)
        {
            GPU gpu = new GPU();
            gpu.Model = mod.Model;
            gpu.Company = mod.Company;
            gpu.GPUChip = mod.GPUChip;
            gpu.Released = mod.Released;
            gpu.Bus = mod.Bus;
            gpu.Memory = mod.Memory;
            gpu.GPUclock = mod.GPUclock;
            gpu.Memoryclock = mod.Memoryclock;
            gpu.Shaders_TMUs_ROPs = mod.Shaders_TMUs_ROPs;
            gpu.PassmarkG3dMark = mod.PassmarkG3dMark;
            gpu.Rank = mod.Rank;
            if (gpuService.GetGPU(gpu.Model) == null && (gpu.Model != null || gpu.GPUChip != null || gpu.Company != null))
            {
                gpuService.InsertGPU(gpu);
            }
            else if(gpu.Model == null || gpu.GPUChip==null || gpu.Company==null)
            {
                return Content($"Null olamaz");
            }
            else
            {
                return Content($"Dublicate var");
            }
            return RedirectToAction("GPUList", new { @mesaj = "Başarılı" });
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditGPU(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            GPU u = gpuService.GetGPU(id);
            GPUViewModel gpuitem = new GPUViewModel
            {
                Model = u.Model,
                Company = u.Company,
                GPUChip = u.GPUChip,
                Released = u.Released,
                Bus = u.Bus,
                Memory = u.Memory,
                GPUclock = u.GPUclock,
                Memoryclock = u.Memoryclock,
                Shaders_TMUs_ROPs = u.Shaders_TMUs_ROPs,
                PassmarkG3dMark = u.PassmarkG3dMark,
                Rank = u.Rank,
            };
            return View(gpuitem);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditGPU(GPUViewModel mod)
        {
            GPU gpu = gpuService.GetGPU(mod.Model);
            gpu.Model = mod.Model;
            gpu.Company = mod.Company;
            gpu.GPUChip = mod.GPUChip;
            gpu.Released = mod.Released;
            gpu.Bus = mod.Bus;
            gpu.Memory = mod.Memory;
            gpu.GPUclock = mod.GPUclock;
            gpu.Memoryclock = mod.Memoryclock;
            gpu.Shaders_TMUs_ROPs = mod.Shaders_TMUs_ROPs;
            gpu.PassmarkG3dMark = mod.PassmarkG3dMark;
            gpu.Rank = mod.Rank;
            if (gpuService.GetGPU(gpu.Model) != null && (gpu.Model != null || gpu.GPUChip != null || gpu.Company != null))
            {
                gpuService.UpdateGPU(gpu);
            }
            else if (gpu.Model == null || gpu.GPUChip == null || gpu.Company == null)
            {
                return Content($"Null olamaz");
            }
            gpuService.UpdateGPU(gpu);
            return RedirectToAction("GPUList", new { @mesaj = "Başarılı" });
        }

        public ActionResult DeleteGPU(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            gpuService.DeleteGPU(id);
            return RedirectToAction("GPUList", new { @mesaj = "Başarılı" });
        }


    }
} 