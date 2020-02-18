using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            MaintenanceType = new HashSet<MaintenanceType>();
            ProjectState = new HashSet<ProjectState>();
            SchoolDetails = new HashSet<SchoolDetails>();
        }

        public int Id { get; set; }
        public DateTime? InitaialDeliveryDate { get; set; }
        public int? SchoolId { get; set; }
        public DateTime? StratWorkDate { get; set; }
        public DateTime? StartWorkDate { get; set; }

        public virtual ICollection<MaintenanceType> MaintenanceType { get; set; }
        public virtual ICollection<ProjectState> ProjectState { get; set; }
        public virtual ICollection<SchoolDetails> SchoolDetails { get; set; }
    }
}
