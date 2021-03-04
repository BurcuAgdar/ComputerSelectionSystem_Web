using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class SystemRequirement:BaseEntity
    {
        public string Amd { get; set; }
        public string Intel { get; set; }
        public string Ram { get; set; }
        
        public string VideoCard1 { get; set; }
        public string VideoCard2 { get; set; }
        public string FreeDiskSpace { get; set; }

    }
}
