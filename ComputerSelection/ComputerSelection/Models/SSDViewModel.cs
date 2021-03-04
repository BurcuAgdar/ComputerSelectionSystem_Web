using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerSelection.Models
{
    public class SSDViewModel
    {
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "MemoryCapacity")]
        public string MemoryCapacity { get; set; }

        [Display(Name = "DiskSize")]
        public string DiskSize { get; set; }

        [Display(Name = "MaxReadSpeed")]
        public string MaxReadSpeed { get; set; }

        [Display(Name = "MaxWriteSpeed")]
        public string MaxWriteSpeed { get; set; }

    }
}
