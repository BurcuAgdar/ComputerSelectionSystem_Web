using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace ComputerSelection.Models
{
    public class RAMViewModel
    {
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "Usage_Type")]
        public string Usage_Type { get; set; }

        [Display(Name = "Memory_Types")]
        public string Memory_Types { get; set; }

        [Display(Name = "Memory_Capacity")]
        public string Memory_Capacity { get; set; }

        [Display(Name = "Memory_Speed")]
        public string Memory_Speed { get; set; }

        [Display(Name = "Delay_Time")]
        public string Delay_Time { get; set; }

        [Display(Name = "Kit_Type")]
        public string Kit_Type { get; set; }

    }
}
