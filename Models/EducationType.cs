﻿using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class EducationType
    {
        public EducationType()
        {
            SchoolDetails = new HashSet<SchoolDetails>();
        }

        public int Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SchoolDetails> SchoolDetails { get; set; }
    }
}