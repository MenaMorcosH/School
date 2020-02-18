using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Building
    {
        public Building()
        {
            Sewage = new HashSet<Sewage>();
            Supplies = new HashSet<Supplies>();
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? ClassesNumber { get; set; }
        public int? SchoolId { get; set; }
        public int? BuilingOwnershipId { get; set; }
        public int? FenceId { get; set; }
        public double? Area { get; set; }
        public int? FoundationMethodId { get; set; }
        public int? FoundationTypeId { get; set; }

        public virtual BuildingOwnership BuilingOwnership { get; set; }
        public virtual Fence Fence { get; set; }
        public virtual FoundationMethod FoundationMethod { get; set; }
        public virtual FoundationType FoundationType { get; set; }
        public virtual SchoolDetails School { get; set; }
        public virtual ICollection<Sewage> Sewage { get; set; }
        public virtual ICollection<Supplies> Supplies { get; set; }
    }
}
