using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class EducationalSpaces
    {
        public int Code { get; set; }
        public int? Number { get; set; }
        public int? SpacesId { get; set; }

        public virtual Spaces Spaces { get; set; }
    }
}
