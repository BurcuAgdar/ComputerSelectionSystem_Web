using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerSelection.Data
{
    public class GPU: BaseEntity
    {
        public string Company { get; set; }
        public string GPUChip { get; set; }
        public string Released { get; set; }
        public string Bus { get; set; }
        public string Memory { get; set; }
        public string GPUclock { get; set; }
        public string Memoryclock { get; set; }
        public string Shaders_TMUs_ROPs { get; set; }
        public int PassmarkG3dMark { get; set; }
        public int Rank { get; set; }

    }
}
