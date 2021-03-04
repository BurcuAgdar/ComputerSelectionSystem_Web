using ComputerSelection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerSelection.Models
{
    public class SelectDesktopViewModel
    {
      
        public List<CPU> cpulist { get; set; }
        public List<GPU> gpulist { get; set; }
        public List<MainBoard> mainboardlist { get; set; }
        public List<HardDisk> harddisklist { get; set; }
        public List<RAM> ramlist { get; set; }
        public List<SSD> ssdlist { get; set; }

    }
}
