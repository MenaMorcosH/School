using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class ProjectState
    {
        public int Code { get; set; }
        public string State { get; set; }
        public int? MintenaceId { get; set; }

        public virtual Maintenance Mintenace { get; set; }
    }
}
