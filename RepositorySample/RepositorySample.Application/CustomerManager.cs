using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Domain;
using Repository.Infrastructure.Repositories;

namespace RepositorySample.Application
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IGenericRepository<Customer> customerRepository;

        public CustomerManager(IGenericRepository<Customer> customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IQueryable<Customer> GetAllActive()
        {
            return customerRepository
                .GetAll(customer => customer.Active);
        }

        public IQueryable<Customer> GetAllBorn(DateTime start, DateTime end)
        {
            return customerRepository.GetAll(
                customer => customer.BornOn >= start && customer.BornOn <= end);
        }
    }
}
