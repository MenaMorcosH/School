using School.Models;
using School.Queries.contracts;
using School.Queries.ReadRepository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Queries.ReadRepository
{
    public class BranchQueries : BaseRepository<Branch>, IBranchQueries
    {

        private string _connectionString = string.Empty;

        public BranchQueries (string constr) : base(constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));

        }
    }
}
