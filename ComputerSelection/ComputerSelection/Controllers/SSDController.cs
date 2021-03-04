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
    public class SSDController : Controller
    {
        private readonly ISSDService ssdService;

        public SSDController(ISSDService ssdService)
        {
            this.ssdService = ssdService;
        }
        [Authorize]
        [HttpGet]


        public IActionResult SSDList()
        {
            List<SSDViewModel> model = new List<SSDViewModel>();
            ssdService.GetSSDs().ToList().ForEach(u =>
            {
                SSD ssd = ssdService.GetSSD(u.Model);
                SSDViewModel ssditem = new SSDViewModel
                {
                    Model = u.Model,
                    MemoryCapacity = u.MemoryCapacity,
                    DiskSize = u.DiskSize,
                    MaxReadSpeed = u.MaxReadSpeed,
                    MaxWriteSpeed = u.MaxWriteSpeed,


                };
                model.Add(ssditem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddSSD()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddSSD(SSD mod)
        {
            SSD ssd = new SSD();
            ssd.Model = mod.Model;
            ssd.MemoryCapacity = mod.MemoryCapacity;
            ssd.DiskSize = mod.DiskSize;
            ssd.MaxReadSpeed = mod.MaxReadSpeed;
            ssd.MaxWriteSpeed = mod.MaxWriteSpeed;
            if (ssdService.GetSSD(ssd.Model) == null && ssd.Model != null && ssd.MemoryCapacity != null)
            {
                ssdService.InsertSSD(ssd);
            }
            else if (ssd.Model == null || ssd.MemoryCapacity == null)
            {
                return Content($"Null olamaz !!!");
            }
            else
            {
                return Content($"Dublicate oldu");
            }

            return RedirectToAction("SSDList", new { @mesaj = "Başarılı" }); ;
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditSSD(string id)
        {

            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            SSD ssd = ssdService.GetSSD(id);
            SSDViewModel ssditem = new SSDViewModel
            {
                Model = ssd.Model,
                MemoryCapacity = ssd.MemoryCapacity,
                DiskSize = ssd.DiskSize,
                MaxReadSpeed = ssd.MaxReadSpeed,
                MaxWriteSpeed = ssd.MaxWriteSpeed
            };

            return View(ssditem);

        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditSSD(SSD mod)
        {
            SSD ssd = ssdService.GetSSD(mod.Model);
            ssd.Model = mod.Model;
            ssd.MemoryCapacity = mod.MemoryCapacity;
            ssd.DiskSize = mod.DiskSize;
            ssd.MaxReadSpeed = mod.MaxReadSpeed;
            ssd.MaxWriteSpeed = mod.MaxWriteSpeed;
            if (ssdService.GetSSD(ssd.Model) != null && ssd.Model != null && ssd.MemoryCapacity != null)
            {
                ssdService.UpdateSSD(ssd);
            }
            else if (ssd.Model == null || ssd.MemoryCapacity == null)
            {
                return Content($"Null olamaz !!!");
            }
           
            return RedirectToAction("SSDList", new { @mesaj = "Başarılı" }); ;
        }

        public ActionResult DeleteSSD(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            ssdService.DeleteSSD(id);
            return RedirectToAction("SSDList", new { @mesaj = "Başarılı" });
        }
    }
}


