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
    public class RAMController:Controller
    {
        private readonly IRAMService ramService;

        public RAMController(IRAMService ramService)
        {
            this.ramService = ramService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult RAMList()
        {
            List<RAMViewModel> model = new List<RAMViewModel>();
            ramService.GetRAMs().ToList().ForEach(u =>
            {
                RAM ram = ramService.GetRAM(u.Model);
                RAMViewModel ramitem = new RAMViewModel
                {
                    Model = u.Model,
                    Usage_Type = u.Usage_Type,
                    Memory_Types = u.Memory_Types,
                    Memory_Capacity = u.Memory_Capacity,
                    Memory_Speed = u.Memory_Speed,
                    Delay_Time = u.Delay_Time,
                    Kit_Type = u.Kit_Type,

                };
                model.Add(ramitem);
            });

            return View(model);
        }
        [Authorize]
        public IActionResult AddRAM()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddRAM(RAM mod)
        {
            RAM ram = new RAM();
            ram.Model = mod.Model;
            ram.Usage_Type = mod.Usage_Type;
            ram.Memory_Types = mod.Memory_Types;
            ram.Memory_Capacity = mod.Memory_Capacity;
            ram.Memory_Speed = mod.Memory_Speed;
            ram.Delay_Time = mod.Delay_Time;
            ram.Kit_Type = mod.Kit_Type;
            if(ramService.GetRAM(ram.Model)==null && ram.Model != null && ram.Memory_Capacity!=null)
            {
                ramService.InsertRAM(ram);
            }
            else if(ram.Model == null && ram.Memory_Capacity == null)
            {
                return Content($"Null olamaz");
            }
            else
            {
                return Content($"Dublicate Oldu");
            }
            return RedirectToAction("RAMList", new { @mesaj = "Başarılı" });
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditRAM(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            RAM ram = ramService.GetRAM(id);
            RAMViewModel ramitem = new RAMViewModel
            {
                Model = ram.Model,
                Usage_Type=ram.Usage_Type,
                Memory_Types = ram.Memory_Types,
                Memory_Speed = ram.Memory_Speed,
                Memory_Capacity = ram.Memory_Capacity,
                Kit_Type = ram.Kit_Type,
                Delay_Time = ram.Delay_Time
            };

            return View(ramitem);

        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditRAM(RAM mod)
        {
            RAM ram = ramService.GetRAM(mod.Model);
            ram.Model = mod.Model;
            ram.Usage_Type = mod.Usage_Type;
            ram.Memory_Types = mod.Memory_Types;
            ram.Memory_Speed = mod.Memory_Speed;
            ram.Memory_Capacity = mod.Memory_Capacity;
            ram.Kit_Type = mod.Kit_Type;
            ram.Delay_Time = mod.Delay_Time;
            if (ramService.GetRAM(ram.Model) != null && ram.Model != null && ram.Memory_Capacity != null)
            {
                ramService.UpdateRAM(ram);
            }
            else if (ram.Model == null && ram.Memory_Capacity == null)
            {
                return Content($"Null olamaz");
            }
            return RedirectToAction("RAMList", new { @mesaj = "Başarılı" });
        }

        public ActionResult DeleteRAM(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            ramService.DeleteRAM(id);
            return RedirectToAction("RAMList", new { @mesaj = "Başarılı" });
        }
    }
}
