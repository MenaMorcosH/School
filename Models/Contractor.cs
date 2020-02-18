using System;
using System.Collections.Generic;

namespace School.Models
{
    public partial class Contractor
    {
        public int Code { get; set; }
        public string ContractorName { get; set; }
        public int? ContractorEngineerId { get; set; }
        public string Adress { get; set; }
        public int? SupervisorEngineerId { get; set; }

        public virtual ContractorEnginner ContractorEngineer { get; set; }
        public virtual SupervisorEngineer SupervisorEngineer { get; set; }
    }
}
