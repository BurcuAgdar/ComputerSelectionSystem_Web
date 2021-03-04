using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class MainBoard:BaseEntity
    {
        public string ProcessorModel { get; set; }
        public string ProcessorSupport { get; set; }
        public string Chipset { get; set; }
        public string SocketStructure { get; set; }
        public string RamType { get; set; }
        public string M2_Slot { get; set; }
        public string CasingStructure { get; set; }
    }
}
