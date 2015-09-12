using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NSubstitute;
using NUnit.Framework;
using Repository.Domain;
using Repository.Infrastructure.Repositories;
using RepositorySample.Application;
using TechTalk.SpecFlow;
using static RepositorySample.Tests.TestHelper;

namespace RepositorySample.Tests
{
    [Binding]
    public class CustomerManagerSteps
    {
        [Given(@"a CustomerManager")]
        public void GivenACustomerManager()
        {
            var customerRepositoryFake = Substitute.For<IGenericRepository<Customer>>();
            var customerManager = new CustomerManager(customerRepositoryFake);
            Bag.CustomerManager = customerManager;
            Bag.CustomerRepositoryFake = customerRepositoryFake;
        }
        
        [When(@"I Call GetAllActive")]
        public void WhenICallGetAllActive()
        {
            var customerManager = Bag.CustomerManager as CustomerManager;
            var customerRepositoryFake = Bag.CustomerRepositoryFake as IGenericRepository<Customer>;
            customerRepositoryFake.GetAll(customer => customer.Active).Returns(new List<Customer>().AsQueryable());
            var result = customerManager.GetAllActive();
            Bag.Result = result;
        }
        
        [Then(@"the result is a query of active customers")]
        public void ThenTheResultIsAQueryOfActiveCustomers()
        {
            var result = Bag.Result;
            Assert.IsInstanceOf(typeof(IQueryable), result);
        }

        [When(@"I Call GetAllBorn")]
        public void WhenICallGetAllBorn()
        {
            var customerManager = Bag.CustomerManager as CustomerManager;
            var customerRepositoryFake = Bag.CustomerRepositoryFake as IGenericRepository<Customer>;
            customerRepositoryFake.GetAll(
                customer => customer.BornOn >= new DateTime() 
                && customer.BornOn <= new DateTime())
                .Returns(new List<Customer>().AsQueryable());
            var result = customerManager.GetAllBorn(new DateTime(), new DateTime());
            Bag.Result = result;
        }

        [Then(@"the result is a query of customers born on between dates")]
        public void ThenTheResultIsAQueryOfCustomersBornOnBetweenDates()
        {
            var result = Bag.Result;
            Assert.IsInstanceOf(typeof(IQueryable), result);
        }

    }
}
