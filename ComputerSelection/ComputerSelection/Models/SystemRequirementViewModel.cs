using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSelection.Models
{
    public class SystemRequirementViewModel
    {
        [Display(Name = "Model")]
        [DataType(DataType.Text)]
        public string Model { get; set; }

        [Display(Name = "AMD")]
        public string AMD { get; set; }

        [Display(Name = "Intel")]
        public string Intel { get; set; }

        [Display(Name = "Ram")]
        public string Ram { get; set; }

        [Display(Name = "VideoCard1")]
        public string VideoCard1 { get; set; }

        [Display(Name = "VideoCard2")]
        public string VideoCard2 { get; set; }

        [Display(Name = "Free Disk Space")]
        public string FreeDiskSpace { get; set; }
    }
}
