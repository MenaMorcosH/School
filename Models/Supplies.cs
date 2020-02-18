using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Supplies
    {
        public int Code { get; set; }
        public int? BuildingId { get; set; }

        public virtual Building Building { get; set; }
    }
}
