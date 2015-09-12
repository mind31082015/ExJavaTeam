using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Repository.Domain;
using Repository.Infrastructure.Repositories;
using RepositorySample.Application;

namespace RepositorySample.Configuration.Modules
{
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<Repository.Infrastructure.Context>();

            Bind<IGenericRepository<Customer>>()
                .To<GenericRepository<Customer>>();

            Bind<CustomerManager>()
                .ToSelf();
        }
    }
}
