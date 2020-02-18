using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class SupervisorEngineer
    {
        public SupervisorEngineer()
        {
            Contractor = new HashSet<Contractor>();
            Extension = new HashSet<Extension>();
        }

        public int Code { get; set; }
        public string SuperviorEngineerName { get; set; }

        public virtual ICollection<Contractor> Contractor { get; set; }
        public virtual ICollection<Extension> Extension { get; set; }
    }
}
