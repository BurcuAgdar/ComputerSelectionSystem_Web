using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ComputerSelection.Models
{
    public class GPUViewModel
    {
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Display(Name = "GPUChip")]
        public string GPUChip { get; set; }

        [Display(Name = "Released")]
        public string Released { get; set; }

        [Display(Name = "Bus")]
        public string Bus { get; set; }

        [Display(Name = "Memory")]
        public string Memory { get; set; }

        [Display(Name = "GPUclock")]
        public string GPUclock { get; set; }

        [Display(Name = "Memoryclock")]
        public string Memoryclock { get; set; }

        [Display(Name = "Shaders_TMUs_ROPs")]
        public string Shaders_TMUs_ROPs { get; set; }

        [Display(Name = "PassmarkG3dMark")]
        public int PassmarkG3dMark { get; set; }

        [Display(Name = "Rank")]
        public int Rank { get; set; }


    }
}
