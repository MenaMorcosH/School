using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Extension
    {
        public int Code { get; set; }
        public string Supervision { get; set; }
        public int? SchoolId { get; set; }
        public int? ContractorId { get; set; }
        public int? SupervisorEngineerId { get; set; }
        public DateTime? InitialDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual SchoolDetails School { get; set; }
        public virtual SupervisorEngineer SupervisorEngineer { get; set; }
    }
}
