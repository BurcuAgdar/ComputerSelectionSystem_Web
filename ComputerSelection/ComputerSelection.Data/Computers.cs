using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class Computers:BaseEntity
    {
        public string DisplayCard { get; set; }
        public string ProcessorType { get; set; }
        public string Ram { get; set; }
        public string ProcessorGeneration { get; set; }
        public string ProcessorModel { get; set; }
        public string OS { get; set; }
        public string Resulation { get; set; }
        public string ScreenSize { get; set; }
        public string SSD_Capacity { get; set; }
        public string Color { get; set; }
    }
}
