using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSelection.Models
{
    public class LogViewModel
    {
        [Display(Name = "Model")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

    }
}
