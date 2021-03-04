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
    public class SystemRequirementController : Controller
    {
        private readonly ISystemRequirementService srService;

        public SystemRequirementController(ISystemRequirementService srService)
        {
            this.srService = srService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult SystemRequirementList()
        {
            List<SystemRequirementViewModel> model = new List<SystemRequirementViewModel>();
            srService.GetSystemRequirements().ToList().ForEach(u =>
            {

                SystemRequirementViewModel sritem = new SystemRequirementViewModel
                {
                    Model = u.Model,
                    AMD = u.Amd,
                    Intel = u.Intel,
                    Ram = u.Ram,
                    VideoCard1 = u.VideoCard1,
                    VideoCard2 = u.VideoCard2,
                FreeDiskSpace = u.FreeDiskSpace
                };
                model.Add(sritem);
            });

            return View(model);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddSystemRequirement()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddSystemRequirement(SystemRequirementViewModel mod)
        {
            SystemRequirement sr = new SystemRequirement();
            sr.Model = mod.Model;
            sr.Amd = mod.AMD;
            sr.Intel = mod.Intel;
            sr.Ram = mod.Ram;
            sr.VideoCard1 = mod.VideoCard1;
            sr.VideoCard2 = mod.VideoCard2;
            sr.FreeDiskSpace = mod.FreeDiskSpace;
            if (srService.GetSYSTEMREQUIRMENT(sr.Model) == null && sr.Model != null)
            {
                srService.InsertSYSTEMREQUIRMENT(sr);
            }
            else if (sr.Model == null )
            {
                return Content($"Null olamaz !!!");
            }
            else
            {
                return Content($"Dublicate oldu");
            }

            return RedirectToAction("SystemRequirementList", new { @mesaj = "Başarılı" }); ;
        }
        [Authorize]
        [HttpGet]
        public IActionResult EditSystemRequirement(string id)
        {

            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            SystemRequirement sr = srService.GetSYSTEMREQUIRMENT(id);
            SystemRequirementViewModel ssditem = new SystemRequirementViewModel
            {
                Model = sr.Model,
                AMD = sr.Amd,
                Intel = sr.Intel,
                Ram = sr.Ram,
                VideoCard1 = sr.VideoCard1,
                VideoCard2 = sr.VideoCard2,
                FreeDiskSpace = sr.FreeDiskSpace
              
            };

            return View(ssditem);

        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditSystemRequirement(SystemRequirementViewModel mod)
        {
            SystemRequirement sr = srService.GetSYSTEMREQUIRMENT(mod.Model);
            sr.Model = mod.Model;
            sr.Amd = mod.AMD;
            sr.Intel = mod.Intel;
            sr.Ram = mod.Ram;
            sr.VideoCard1 = mod.VideoCard1;
            sr.VideoCard2 = mod.VideoCard2;
            sr.FreeDiskSpace = mod.FreeDiskSpace;
            srService.UpdateSYSTEMREQUIRMENT(sr);
            return RedirectToAction("SystemRequirementList", new { @mesaj = "Başarılı" }); ;
        }
       /* [HttpPost]*/
        public ActionResult DeleteSystemRequirement(string id)
        {
            if (id.Contains("%2F"))
            {
                id = id.Replace("%2F", "/");
            }
            srService.DeleteSYSTEMREQUIRMENT(id);
            return RedirectToAction("SystemRequirementList", new { @mesaj = "Başarılı" });
        }
    }
}
