using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class LandOwnership
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int? SchoolId { get; set; }

        public virtual SchoolDetails School { get; set; }
    }
}
