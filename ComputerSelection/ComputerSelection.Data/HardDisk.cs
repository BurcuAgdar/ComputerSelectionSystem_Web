using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class HardDisk:BaseEntity
    {
        public string MemoryCapacity { get; set; }
        public string ConnectionType { get; set; }
        public string Cache { get; set; }
        public string RotationSpeed { get; set; }
        public string DiskSize { get; set; }

    }
}
