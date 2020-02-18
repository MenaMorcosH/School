using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class ContractorEnginner
    {
        public ContractorEnginner()
        {
            Contractor = new HashSet<Contractor>();
        }

        public int Code { get; set; }
        public string ContractorEngineerName { get; set; }

        public virtual ICollection<Contractor> Contractor { get; set; }
    }
}
