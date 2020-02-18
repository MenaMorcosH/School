using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Image
    {
        public string Id { get; set; }
        public string Pics { get; set; }
        public int? SchoolId { get; set; }

        public virtual SchoolDetails School { get; set; }
    }
}
