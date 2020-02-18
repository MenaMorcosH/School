using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Spaces
    {
        public Spaces()
        {
            AdditionalSpaces = new HashSet<AdditionalSpaces>();
            EducationalSpaces = new HashSet<EducationalSpaces>();
        }

        public int Code { get; set; }
        public string Type { get; set; }
        public int? SchoolId { get; set; }

        public virtual SchoolDetails School { get; set; }
        public virtual ICollection<AdditionalSpaces> AdditionalSpaces { get; set; }
        public virtual ICollection<EducationalSpaces> EducationalSpaces { get; set; }
    }
}
