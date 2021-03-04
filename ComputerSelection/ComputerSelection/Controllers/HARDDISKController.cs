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
    public class HARDDISKController:Controller
    {
        private readonly IHARDDISKService hardDiskService;


        public HARDDISKController(IHARDDISKService hardDiskService)
        {
            this.hardDiskService = hardDiskService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult HardDiskList()
        {
            List<HARDDISKViewModel> model = new List<HARDDISKViewModel>();
          
            hardDiskService.GetHARDDISKs().ToList().ForEach(u =>
            {
                HardDisk hd = hardDiskService.GetHARDDISK(u.Model);
                HARDDISKViewModel hditem = new HARDDISKViewModel
                {
                    Model = u.Model,
                    MemoryCapacity = u.MemoryCapacity,
                    ConnectionType = u.ConnectionType,
                    Cache = u.Cache,
                    RotationSpeed = u.RotationSpeed,
                    DiskSize = u.DiskSize,
                };
                model.Add(hditem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddHarddisk()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddHarddisk(HARDDISKViewModel mod)
        {
            HardDisk hdd = new HardDisk();
            hdd.Model = mod.Model;
            hdd.MemoryCapacity = mod.MemoryCapacity;
            hdd.ConnectionType = mod.ConnectionType;
            hdd.Cache = mod.Cache;
            hdd.RotationSpeed = mod.Cache;
            hdd.DiskSize = mod.DiskSize;
            if (hardDiskService.GetHARDDISK(hdd.Model) == null && (hdd.Model != null || hdd.MemoryCapacity != null || hdd.RotationSpeed != null))
            {
                hardDiskService.InsertHARDDISK(hdd);
            }
            else if (hdd.Model == null || hdd.MemoryCapacity == null || hdd.DiskSize == null)
            {
                return Content($"Null olamaz");
            }
            else
            {
                return Content($"Dublicate İşlemi Yaptın");
            }
            return RedirectToAction("HardDiskList", new { @mesaj = "Başarılı" });
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditHardDisk(string id)
        {
            if(id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            HardDisk u = hardDiskService.GetHARDDISK(id);

            HARDDISKViewModel harddisk = new HARDDISKViewModel
            {
                Model = u.Model,
                Cache = u.Cache,
                ConnectionType = u.ConnectionType,
                DiskSize = u.DiskSize,
                MemoryCapacity = u.MemoryCapacity,
                RotationSpeed = u.RotationSpeed,
            };
            return View(harddisk);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditHardDisk(HARDDISKViewModel mod)
        {
            HardDisk hdd = hardDiskService.GetHARDDISK(mod.Model);
            hdd.Model = mod.Model;
            hdd.Cache = mod.Cache;
            hdd.ConnectionType = mod.ConnectionType;
            hdd.DiskSize = mod.DiskSize;
            hdd.MemoryCapacity = mod.MemoryCapacity;
            hdd.RotationSpeed = mod.RotationSpeed;
            if (hardDiskService.GetHARDDISK(hdd.Model) != null && (hdd.Model != null || hdd.MemoryCapacity != null || hdd.DiskSize != null))
            {
                hardDiskService.UpdateHARDDISK(hdd);
            }
            else if (hdd.Model == null || hdd.MemoryCapacity == null || hdd.RotationSpeed == null)
            {
                return Content($"Null olamaz");
            }
            return RedirectToAction("HardDiskList", new { @mesaj = "Başarılı" });
        }

        public ActionResult DeleteHARDDISK(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            hardDiskService.DeleteHARDDISK(id);
            return RedirectToAction("HardDiskList", new { @mesaj = "Başarılı" });
        }

    }
}
