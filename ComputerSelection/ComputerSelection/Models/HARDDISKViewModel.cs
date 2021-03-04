using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace ComputerSelection.Models
{
    public class HARDDISKViewModel
    {

        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "MemoryCapacity")]
        public string MemoryCapacity { get; set; }

        [Display(Name = "ConnectionType")]
        public string ConnectionType { get; set; }

        [Display(Name = "Cache")]
        public string Cache { get; set; }

        [Display(Name = "RotationSpeed")]
        public string RotationSpeed { get; set; }

        [Display(Name = "DiskSize")]
        public string DiskSize { get; set; }

       
    }
}
