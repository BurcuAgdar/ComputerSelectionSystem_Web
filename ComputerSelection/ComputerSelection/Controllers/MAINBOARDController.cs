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
    public class MAINBOARDController:Controller
    {
        private readonly IMAINBOARDService mainboardService;

        public MAINBOARDController(IMAINBOARDService mainboardService)
        {
            this.mainboardService = mainboardService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult MAINBOARDList()
        {
            List<MAINBOARDViewModel> model = new List<MAINBOARDViewModel>();
            mainboardService.GetMAINBOARDs().ToList().ForEach(u =>
            {
                MainBoard mainboard = mainboardService.GetMAINBOARD(u.Model);
                MAINBOARDViewModel mainboarditem = new MAINBOARDViewModel
                {
                    Model = u.Model,
                    ProcessorModel = u.ProcessorModel,
                    ProcessorSupport = u.ProcessorSupport,
                    Chipset = u.Chipset,
                    SocketStructure = u.SocketStructure,
                    RamType = u.RamType,
                    M2_Slot = u.M2_Slot,
                    CasingStructure = u.CasingStructure,
                    
                };
                model.Add(mainboarditem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddMainBoard()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddMainBoard(MAINBOARDViewModel mod)
        {
            MainBoard mainboard = new MainBoard();
            mainboard.Model = mod.Model;
            mainboard.ProcessorModel = mod.ProcessorModel;
            mainboard.ProcessorSupport = mod.Chipset;
            mainboard.Chipset = mod.Chipset;
            mainboard.SocketStructure = mod.SocketStructure;
            mainboard.RamType = mod.RamType;
            mainboard.M2_Slot = mod.M2_Slot;
            mainboard.CasingStructure = mod.CasingStructure;
            if (mainboardService.GetMAINBOARD(mainboard.Model) == null && mainboard.Model != null && mainboard.ProcessorModel != null && mainboard.ProcessorSupport != null && mainboard.SocketStructure !=null && mainboard.RamType != null)
            {
                mainboardService.InsertMAINBOARD(mainboard);
            }
            else if (mainboard.Model == null || mainboard.ProcessorModel == null || mainboard.ProcessorSupport == null || mainboard.SocketStructure == null || mainboard.RamType == null)
            {
                return Content($"Null Veri Yollayamazsın");
            }
            else
            {
                return Content($"Dublicate İşlemi Yaptın");
            }

            
            return RedirectToAction("MAINBOARDList", new { @mesaj = "Başarılı" });
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditMAINBOARD(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            MainBoard mainboard = mainboardService.GetMAINBOARD(id);
            MAINBOARDViewModel mainboarditem = new MAINBOARDViewModel
            {
                Model = mainboard.Model,
                ProcessorModel = mainboard.ProcessorModel,
                ProcessorSupport = mainboard.ProcessorSupport,
                Chipset = mainboard.Chipset,
                SocketStructure = mainboard.SocketStructure,
                RamType = mainboard.RamType,
                M2_Slot = mainboard.M2_Slot,
                CasingStructure = mainboard.CasingStructure
            };

            return View(mainboarditem);

        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditMAINBOARD(MAINBOARDViewModel mod)
        {
            MainBoard mainboard = mainboardService.GetMAINBOARD(mod.Model);
            mainboard.Model = mod.Model;
            mainboard.ProcessorModel = mod.ProcessorModel;
            mainboard.ProcessorSupport = mod.ProcessorSupport;
            mainboard.Chipset = mod.Chipset;
            mainboard.SocketStructure = mod.SocketStructure;
            mainboard.RamType = mod.RamType;
            mainboard.M2_Slot = mod.M2_Slot;
            mainboard.CasingStructure = mod.CasingStructure;
            if (mainboardService.GetMAINBOARD(mainboard.Model) != null && mainboard.Model != null && mainboard.ProcessorModel != null && mainboard.ProcessorSupport != null && mainboard.SocketStructure != null && mainboard.RamType != null)
            {
                mainboardService.UpdateMAINBOARD(mainboard);
            }
            else if (mainboard.Model == null || mainboard.ProcessorModel == null || mainboard.ProcessorSupport == null || mainboard.SocketStructure == null || mainboard.RamType == null)
            {
                return Content($"Null Veri Yollayamazsın");
            }     
            return RedirectToAction("MAINBOARDList", new { @mesaj = "Başarılı" }); ;
        }
        public ActionResult DeleteMAINBOARD(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            mainboardService.DeleteMAINBOARD(id);
            return RedirectToAction("MAINBOARDList", new { @mesaj = "Başarılı" });
        }
    }


}

