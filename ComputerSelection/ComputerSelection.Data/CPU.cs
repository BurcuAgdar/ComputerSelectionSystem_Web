using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class CPU:BaseEntity
    {
        public Int16 CpuCore { get; set; }
        public Int16 ThreatNumber { get; set; }
        public string Released { get; set; }
        public string BaseClock { get; set; }
        public string MaxClock { get; set; }
        public string SocketType { get; set; }
        public string TDP { get; set; }
        public string MemoryType { get; set; }
        public string MemoryFrequancy { get; set; }
        public string Type { get; set; }
        public string Apu { get; set; }
        public string ApuFrequancy { get; set; }
        public double CpuMark { get; set; }
        public int Rank { get; set; }
    }
}
