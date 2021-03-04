using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerSelection.Models
{
    public class CPUViewModel
    {

        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "CpuCore")]
        public Int16 CpuCore { get; set; }

        [Display(Name = "ThreatNumber")]
        public Int16 ThreatNumber { get; set; }

        [Display(Name = "Released")]
        public string Released { get; set; }

        [Display(Name = "Base Clock")]
        public string BaseClock { get; set; }

        [Display(Name = "Max Clock")]
        public string MaxClock { get; set; }

        [Display(Name = "Socket Type")]
        public string SocketType { get; set; }

        [Display(Name = "TDP")]
        public string TDP { get; set; }

        [Display(Name = "Memory Type")]
        public string MemoryType { get; set; }

        [Display(Name = "Memory Frequency")]
        public string MemoryFrequency { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Apu")]
        public string Apu { get; set; }

        [Display(Name = "Apu Frequency")]
        public string ApuFrequency { get; set; }

        [Display(Name = "Cpu Mark")]
        public double CpuMark { get; set; }

        [Display(Name = "Rank")]
        public int Rank { get; set; }



    }
}
