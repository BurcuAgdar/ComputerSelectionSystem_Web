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
    public class LogController:Controller
    {
        private readonly ILogService logService;

        public LogController(ILogService logService)
        {
            this.logService = logService;
        }
        [Authorize]
        public IActionResult LogList()
        {
            List<LogViewModel> model = new List<LogViewModel>();
            logService.GetLogs().ToList().ForEach(u =>
            {
                Log log = logService.GetLog(u.Model);
                LogViewModel logitem = new LogViewModel
                {
                    Model = u.Model,
                    Date = u.Date,
                    
                };
                model.Add(logitem);
            });

            return View(model);
        }
    }
}
