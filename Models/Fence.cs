using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Fence
    {
        public Fence()
        {
            Building = new HashSet<Building>();
        }

        public int Code { get; set; }
        public int? Fence1 { get; set; }

        public virtual ICollection<Building> Building { get; set; }
    }
}
