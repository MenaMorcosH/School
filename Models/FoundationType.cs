using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class FoundationType
    {
        public FoundationType()
        {
            Building = new HashSet<Building>();
        }

        public int Code { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Building> Building { get; set; }
    }
}
