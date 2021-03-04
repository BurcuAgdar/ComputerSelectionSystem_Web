using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSelection.Models
{
    public class ComputerViewModel
    {
        [Display(Name = "Model")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "Display Card")]
        public string DisplayCard { get; set; }

        [Display(Name = "Processor Type")]
        public string ProcessorType { get; set; }

        [Display(Name = "Ram")]
        public string Ram { get; set; }

        [Display(Name = "Processor Generation")]
        public string ProcessorGeneration { get; set; }

        [Display(Name = "Processor Model")]
        public string ProcessorModel { get; set; }

        [Display(Name = "OS")]
        public string OS { get; set; }

        [Display(Name = "Resulation")]
        public string Resulation { get; set; }

        [Display(Name = "Screen Size")]
        public string ScreenSize { get; set; }

        [Display(Name = "SSD Capacity")]
        public string SSD_Capacity { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }
    }
}
