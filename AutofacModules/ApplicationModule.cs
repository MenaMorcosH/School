using Autofac;
using School.Queries.contracts;
using School.Queries.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {
        public  string _QueriesConnectionString { get; }

        public ApplicationModule(string connectionString)
        {
            _QueriesConnectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.Register(c => new BranchQueries(_QueriesConnectionString))
                    .As<IBranchQueries>()
                    .InstancePerLifetimeScope();



        }

    }
}
