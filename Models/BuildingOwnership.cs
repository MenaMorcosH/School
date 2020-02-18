using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class BuildingOwnership
    {
        public BuildingOwnership()
        {
            Building = new HashSet<Building>();
        }

        public int Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Building> Building { get; set; }
    }
}
