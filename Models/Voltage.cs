using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Voltage
    {
        public Voltage()
        {
            SchoolDetails = new HashSet<SchoolDetails>();
        }

        public int Code { get; set; }
        public string Voltage1 { get; set; }

        public virtual ICollection<SchoolDetails> SchoolDetails { get; set; }
    }
}
