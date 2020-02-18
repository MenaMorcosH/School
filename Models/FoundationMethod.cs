using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class FoundationMethod
    {
        public FoundationMethod()
        {
            Building = new HashSet<Building>();
        }

        public int Code { get; set; }
        public string Method { get; set; }

        public virtual ICollection<Building> Building { get; set; }
    }
}
