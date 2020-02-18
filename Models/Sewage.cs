using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Sewage
    {
        public Sewage()
        {
            SchoolDetails = new HashSet<SchoolDetails>();
        }

        public int Code { get; set; }
        public string Type { get; set; }
        public int? BuildingId { get; set; }

        public virtual Building Building { get; set; }
        public virtual ICollection<SchoolDetails> SchoolDetails { get; set; }
    }
}
