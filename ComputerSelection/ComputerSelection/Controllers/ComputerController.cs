using ComputerSelection.Data;
using ComputerSelection.Models;
using ComputerSelection.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSelection.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService ComputerService;


        public ComputerController(IComputerService ComputerService)
        {
            this.ComputerService = ComputerService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult ComputerList()
        {
            List<ComputerViewModel> model = new List<ComputerViewModel>();

            ComputerService.GetComputers().ToList().ForEach(u =>
            {
                Computers c = ComputerService.GetComputer(u.Model);
                ComputerViewModel citem = new ComputerViewModel
                {
                    Model = u.Model,
                    DisplayCard = u.DisplayCard,
                    ProcessorType = u.ProcessorType,
                    Ram = u.Ram,
                    ProcessorGeneration = u.ProcessorGeneration,
                    ProcessorModel = u.ProcessorModel,
                    OS = u.OS,
                    Resulation = u.Resulation,
                    ScreenSize = u.ScreenSize,
                    SSD_Capacity = u.SSD_Capacity,
                    Color = u.Color,
                };
                model.Add(citem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddComputer()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddComputer(ComputerViewModel mod)
        {
            Computers c = new Computers();
            c.Model = mod.Model;
            c.DisplayCard = mod.DisplayCard;
            c.ProcessorType = mod.ProcessorType;
            c.Ram = mod.Ram;
            c.ProcessorGeneration = mod.ProcessorGeneration;
            c.ProcessorModel = mod.ProcessorModel;
            c.OS = mod.OS;
            c.Resulation = mod.Resulation;
            c.ScreenSize = mod.ScreenSize;
            c.SSD_Capacity = mod.SSD_Capacity;
            c.Color = mod.Color;
            if (ComputerService.GetComputer(c.Model) == null && (c.Model != null || c.Ram!=null||c.ProcessorGeneration!=null||c.ProcessorModel!=null))
            {
                ComputerService.InsertComputer(c);
            }
            else if (c.Model == null || c.Ram != null || c.ProcessorGeneration == null || c.ProcessorModel == null)
            {
                return Content($"Null olamaz");
            }
            else
            {
                return Content($"Dublicate İşlemi Yaptın");
            }
            return RedirectToAction("ComputerList", new { @mesaj = "Başarılı" });
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditComputer(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            Computers u = ComputerService.GetComputer(id);

            ComputerViewModel com = new ComputerViewModel
            {
                Model = u.Model,
                DisplayCard = u.DisplayCard,
                ProcessorType = u.ProcessorType,
                Ram=u.Ram,
                ProcessorGeneration=u.ProcessorGeneration,
                ProcessorModel=u.ProcessorModel,
                OS=u.OS,
                Resulation=u.Resulation,
                ScreenSize=u.ScreenSize,
                SSD_Capacity=u.SSD_Capacity,
                Color=u.Color
            };
            return View(com);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditComputer(ComputerViewModel mod)
        {
            Computers c = ComputerService.GetComputer(mod.Model);
            c.Model = mod.Model;
            c.DisplayCard = mod.DisplayCard;
            c.ProcessorType = mod.ProcessorType;
            c.Ram = mod.Ram;
            c.ProcessorGeneration = mod.ProcessorGeneration;
            c.ProcessorModel = mod.ProcessorModel;
            c.OS = mod.OS;
            c.Resulation = mod.Resulation;
            c.ScreenSize = mod.ScreenSize;
            c.SSD_Capacity = mod.SSD_Capacity;
            c.Color = mod.Color;
            if (ComputerService.GetComputer(c.Model) != null && (c.Model != null || c.Ram != null || c.ProcessorGeneration != null || c.ProcessorModel != null))
            {
                ComputerService.UpdateComputer(c);
            }
            else if (c.Model == null || c.Ram != null || c.ProcessorGeneration == null || c.ProcessorModel == null)
            {
                return Content($"Null olamaz");
            }
            return RedirectToAction("ComputerList", new { @mesaj = "Başarılı" });
        }

        public ActionResult DeleteComputer(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            ComputerService.DeleteComputer(id);
            return RedirectToAction("ComputerList", new { @mesaj = "Başarılı" });
        }
    }
}
