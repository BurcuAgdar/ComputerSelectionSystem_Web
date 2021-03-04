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
    public class CPUController : Controller
    {
        private readonly ICPUService cpuService;

        public CPUController(ICPUService cpuService)
        {
            this.cpuService = cpuService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult CPUList()
        {
            List<CPUViewModel> model = new List<CPUViewModel>();
            cpuService.GetCPUs().ToList().ForEach(u =>
            {
                CPU cpu = cpuService.GetCPU(u.Model);
                CPUViewModel cpuitem = new CPUViewModel
                {
                    Model = u.Model,
                    CpuCore = u.CpuCore,
                    ThreatNumber = u.ThreatNumber,
                    Released = u.Released,
                    BaseClock = u.BaseClock,
                    MaxClock = u.MaxClock,
                    SocketType=u.SocketType,
                    TDP = u.TDP,
                    MemoryType = u.MemoryType,
                    MemoryFrequency = u.MemoryFrequancy,
                    Type = u.Type,
                    Apu = u.Apu,
                    ApuFrequency = u.ApuFrequancy,
                    CpuMark = u.CpuMark,
                    Rank = u.Rank
                };
                model.Add(cpuitem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddCPU()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddCPU(CPUViewModel mod)
        {
            CPU cpu = new CPU();
            cpu.Model = mod.Model;
            cpu.CpuCore = mod.CpuCore;
            cpu.ThreatNumber = mod.ThreatNumber;
            cpu.Released = mod.Released;
            cpu.BaseClock = mod.BaseClock;
            cpu.MaxClock = mod.MaxClock;
            cpu.SocketType = mod.SocketType;
            cpu.TDP = mod.TDP;
            cpu.MemoryType = mod.MemoryType;
            cpu.MemoryFrequancy = mod.MemoryFrequency;
            cpu.Type = mod.Type;
            cpu.Apu = mod.Apu;
            if (cpuService.GetCPU(cpu.Model) == null && cpu.Model != null)
            {
                cpuService.InsertCPU(cpu);
            }
            else if (cpu.Model == null)
            {
                return Content($"Null Veri Yollayamazsın");
            }
            else
            {
                return Content($"Dublicate İşlemi Yaptın");
            }
            return RedirectToAction("CPUList", new { @mesaj = "Başarılı" });

        }
        [Authorize]
        [HttpGet]
        public IActionResult EditCPU(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            CPU u = cpuService.GetCPU(id);
            CPUViewModel cpuitem = new CPUViewModel
            {
                Model = u.Model,
                CpuCore = u.CpuCore,
                ThreatNumber = u.ThreatNumber,
                Released = u.Released,
                BaseClock = u.BaseClock,
                MaxClock = u.MaxClock,
                SocketType=u.SocketType,
                TDP = u.TDP,
                MemoryType = u.MemoryType,
                MemoryFrequency = u.MemoryFrequancy,
                Type = u.Type,
                Apu = u.Apu,
                ApuFrequency = u.ApuFrequancy,
                CpuMark = u.CpuMark,
                Rank = u.Rank
            };
            return View(cpuitem);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditCPU(CPUViewModel mod)
        {
            CPU cpu=cpuService.GetCPU(mod.Model);
            cpu.Model = mod.Model;
            cpu.CpuCore = mod.CpuCore;
            cpu.ThreatNumber = mod.ThreatNumber;
            cpu.Released = mod.Released;
            cpu.BaseClock = mod.BaseClock;
            cpu.MaxClock = mod.MaxClock;
            cpu.SocketType = mod.SocketType;
            cpu.TDP = mod.TDP;
            cpu.MemoryType = mod.MemoryType;
            cpu.MemoryFrequancy = mod.MemoryFrequency;
            cpu.Type = mod.Type;
            cpu.Apu = mod.Apu;
            cpu.ApuFrequancy = mod.ApuFrequency;
            cpu.CpuMark = mod.CpuMark;
            cpu.Rank = mod.Rank;
            cpuService.UpdateCPU(cpu);
            return RedirectToAction("CPUList", new { @mesaj = "Başarılı" });
        }

        public ActionResult DeleteCPU(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            cpuService.DeleteCPU(id);
            return RedirectToAction("CPUList", new { @mesaj = "Başarılı" });
        }
    }
}
