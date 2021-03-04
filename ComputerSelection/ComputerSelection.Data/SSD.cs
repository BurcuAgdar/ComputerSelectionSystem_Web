using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class SSD: BaseEntity
    {
        public string MemoryCapacity { get; set; }
        public string DiskSize { get; set; }
        public string MaxReadSpeed { get; set; }
        public string MaxWriteSpeed { get; set; }


    }
}
