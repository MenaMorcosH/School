using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class MaintenanceType
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public int? MaintenanceId { get; set; }

        public virtual Maintenance Maintenance { get; set; }
    }
}
