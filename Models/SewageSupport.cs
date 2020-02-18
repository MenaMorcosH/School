using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class SewageSupport
    {
        public SewageSupport()
        {
            SchoolDetails = new HashSet<SchoolDetails>();
        }

        public int Code { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SchoolDetails> SchoolDetails { get; set; }
    }
}
