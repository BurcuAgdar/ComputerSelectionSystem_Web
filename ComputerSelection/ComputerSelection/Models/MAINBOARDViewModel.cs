using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace ComputerSelection.Models
{
    public class MAINBOARDViewModel
    {
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "ProcessorModel")]
        public string ProcessorModel { get; set; }

        [Display(Name = "ProcessorSupport")]
        public string ProcessorSupport { get; set; }

        [Display(Name = "Chipset")]
        public string Chipset { get; set; }

        [Display(Name = "SocketStructure")]
        public string SocketStructure { get; set; }

        [Display(Name = "RamType")]
        public string RamType { get; set; }

        [Display(Name = "M2_Slot")]
        public string M2_Slot { get; set; }

        [Display(Name = "CasingStructure")]
        public string CasingStructure { get; set; }
    }
}
