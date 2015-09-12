using System;
using System.Linq;
using Repository.Domain;

namespace RepositorySample.Application
{
    public interface ICustomerManager
    {
        IQueryable<Customer> GetAllActive();
        IQueryable<Customer> GetAllBorn(DateTime start, DateTime end);
    }
}