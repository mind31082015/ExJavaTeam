using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using RepositorySample.Application;
using Repository.Domain;

namespace RepositorySample.Tests
{
    public class FakeCustomerManager : ICustomerManager
    {
        public IQueryable<Customer> GetAllActive()
        {
            return new List<Customer>().AsQueryable();
        }

        public IQueryable<Customer> GetAllBorn(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
