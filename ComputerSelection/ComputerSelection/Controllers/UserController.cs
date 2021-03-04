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
using System.Web.Providers.Entities;
using Microsoft.AspNetCore.Http;

namespace ComputerSelection.Controllers
{
    public class UserController : Controller
    {
        string cpuRank, gpuRank;
        private readonly ICPUService cpuService;
        private readonly ISSDService ssdService;
        private readonly IGPUService gpuService;
        private readonly IHARDDISKService hardDiskService;
        private readonly IRAMService ramService;
        private readonly IComputerService ComputerService;
        private readonly IMAINBOARDService mainboardService;
        private readonly ISystemRequirementService sysService;
        public UserController(ISSDService ssdService
            , IRAMService ramService, ICPUService cpuService, IGPUService gpuService, IMAINBOARDService mainboardService, IHARDDISKService hardDiskServices, IComputerService ComputerService, ISystemRequirementService systemRequirementService)
        {
            this.gpuRank = "_bb";
            this.cpuRank = "_ee";
            this.ramService = ramService;
            this.cpuService = cpuService;
            this.gpuService = gpuService;
            this.hardDiskService = hardDiskServices;
            this.mainboardService = mainboardService;
            this.ComputerService = ComputerService;
            this.ssdService = ssdService;
            this.sysService = systemRequirementService;
        }
        [HttpGet]
        public IActionResult UserL()
        {
            IEnumerable<SystemRequirement> item = sysService.GetSystemRequirements();
            return View(item);
        }
        
       [HttpPost]
      public IActionResult UserL([FromBody] IEnumerable<UserViewModel> item)
       {
           int maxcpurank = 0;
           int maxgpurank = 0;
           foreach (UserViewModel us in item)
           {
                //contains ile güncelleme gerekebilir.Eger hata gelirse lütfen içerisinde karakter barındırmayan oyun ismiyle deneyin
                SystemRequirement sr = sysService.GetSYSTEMREQUIRMENT(us.GameName);
               if(cpuService.GetContains(sr.Amd)!=null)
               {
                   maxcpurank = Math.Max(cpuService.GetContains(sr.Amd).Rank, maxcpurank);
               }
               if (cpuService.GetContains(sr.Intel) != null)
               {
                   maxcpurank = Math.Max(cpuService.GetContains(sr.Intel).Rank, maxcpurank);
               }


               if (maxcpurank == 0)
               {
                   maxcpurank = 2000;
               }


               if(gpuService.GetContains(sr.VideoCard1)!=null)
               {
                   maxgpurank = Math.Max(gpuService.GetContains(sr.VideoCard1).Rank, maxgpurank);
               }

               if(gpuService.GetContains(sr.VideoCard2) != null)
               {
                   maxgpurank = Math.Max(gpuService.GetContains(sr.VideoCard2).Rank, maxgpurank);
               }

               if (maxgpurank == 0)
               {
                   maxgpurank = 550;
               }


           }
          
            HttpContext.Session.SetInt32(cpuRank, maxcpurank);
            HttpContext.Session.SetInt32(gpuRank, maxgpurank);
            return RedirectToAction("UserSelectLaptop","User");

       }
        [HttpPost]

        public IActionResult UserD([FromBody] IEnumerable<UserViewModel> item)
        {
            int maxcpurank = 0;
            int maxgpurank = 0;
            foreach (UserViewModel us in item)
            {
                //contains ile güncelleme gerekebilir.Eger hata gelirse lütfen içerisinde karakter barındırmayan oyun ismiyle deneyin
                SystemRequirement sr = sysService.GetSYSTEMREQUIRMENT(us.GameName);
                if (cpuService.GetContains(sr.Amd) != null)
                {
                    maxcpurank = Math.Max(cpuService.GetContains(sr.Amd).Rank, maxcpurank);
                }
                if (cpuService.GetContains(sr.Intel) != null)
                {
                    maxcpurank = Math.Max(cpuService.GetContains(sr.Intel).Rank, maxcpurank);
                }


                if (maxcpurank == 0)
                {
                    maxcpurank = 2000;
                }


                if (gpuService.GetContains(sr.VideoCard1) != null)
                {
                    maxgpurank = Math.Max(gpuService.GetContains(sr.VideoCard1).Rank, maxgpurank);
                }

                if (gpuService.GetContains(sr.VideoCard2) != null)
                {
                    maxgpurank = Math.Max(gpuService.GetContains(sr.VideoCard2).Rank, maxgpurank);
                }

                if (maxgpurank == 0)
                {
                    maxgpurank = 550;
                }


            }

            HttpContext.Session.SetInt32(cpuRank, maxcpurank);
            HttpContext.Session.SetInt32(gpuRank, maxgpurank);
            return RedirectToAction("UserSelectDesktop", "User");
        }
      
        
        public IActionResult UserSelectLaptop()
        {

           
            List<ComputerViewModel> model = new List<ComputerViewModel>();
            SelectorViewModel selectoritem = new SelectorViewModel
            {
                CPURank = Convert.ToInt32(HttpContext.Session.GetInt32(cpuRank)),
                GpuRank = Convert.ToInt32(HttpContext.Session.GetInt32(gpuRank))
        };

            foreach (Computers comp in ComputerService.GetComputers())
            {
                if(cpuService.GetContains(comp.ProcessorModel)!=null && gpuService.GetContains(comp.DisplayCard) != null)
                {
                    if (cpuService.GetContains(comp.ProcessorModel).Rank > selectoritem.CPURank && gpuService.GetContains(comp.DisplayCard).Rank > selectoritem.GpuRank)
                    {
                       
                        ComputerViewModel citem = new ComputerViewModel
                        {
                            Model = comp.Model,
                            DisplayCard = comp.DisplayCard,
                            ProcessorType = comp.ProcessorType,
                            Ram = comp.Ram,
                            ProcessorGeneration = comp.ProcessorGeneration,
                            ProcessorModel = comp.ProcessorModel,
                            OS = comp.OS,
                            Resulation = comp.Resulation,
                            ScreenSize = comp.ScreenSize,
                            SSD_Capacity = comp.SSD_Capacity,
                            Color = comp.Color,
                        };
                        model.Add(citem);
                    
                }
                }
                
            }

            return View(model);
        }
       
       
        public IActionResult UserSelectDesktop()
        {

            
            SelectorViewModel selectoritem = new SelectorViewModel
            {
                CPURank = Convert.ToInt32(HttpContext.Session.GetInt32(cpuRank)),
                GpuRank = Convert.ToInt32(HttpContext.Session.GetInt32(gpuRank))
            };
            List<CPU> cpus = new List<CPU>();
            List<GPU> gpus = new List<GPU>();
            List<MainBoard> mainboardlist = new List<MainBoard>();
            List<HardDisk> harddisklist = new List<HardDisk>();
            List<RAM> ramlist = new List<RAM>();
            List<SSD> ssdlist = new List<SSD>();
            foreach (CPU cpu in cpuService.GetCPUs())
            {
                if (cpu.Rank >= selectoritem.CPURank)
                {
                    cpus.Add(cpu);
                }
            }
            foreach (GPU gpu in gpuService.GetGPUs())
            {
                if (gpu.Rank >= selectoritem.GpuRank)
                {
                    gpus.Add(gpu);
                }
            }
            foreach (MainBoard mb in mainboardService.GetMAINBOARDs())
            {

                mainboardlist.Add(mb);
                
            }
            foreach (HardDisk hd in hardDiskService.GetHARDDISKs())
            {

                harddisklist.Add(hd);

            }
            foreach (RAM rm in ramService.GetRAMs())
            {

                ramlist.Add(rm);

            }
            foreach (SSD sd in ssdService.GetSSDs())
            {

                ssdlist.Add(sd);

            }
            SelectDesktopViewModel desktop = new SelectDesktopViewModel
            {
                cpulist = cpus,
                gpulist = gpus,
                mainboardlist = mainboardlist,
                harddisklist = harddisklist,
                ramlist = ramlist,
                ssdlist = ssdlist

            };
            return View(desktop);
        }
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
                    SocketType = u.SocketType,
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
        [HttpGet]
        public IActionResult MainBoardList()
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
         [HttpGet]
        public IActionResult SystemRequirementList()
        {
            List<SystemRequirementViewModel> model = new List<SystemRequirementViewModel>();
            sysService.GetSystemRequirements().ToList().ForEach(u =>
            {
                SystemRequirement systemreq = sysService.GetSYSTEMREQUIRMENT(u.Model);
                SystemRequirementViewModel systemreqitem = new SystemRequirementViewModel
                {
                    Model = u.Model,
                    AMD = u.Amd,
                    Intel = u.Intel,
                    Ram = u.Ram,
                    VideoCard1 = u.VideoCard1,
                    VideoCard2 = u.VideoCard2,
                    FreeDiskSpace = u.FreeDiskSpace,
                };
                model.Add(systemreqitem);
            });
            return View(model);
        }
    }
}
