using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NSubstitute;
using Repository.Domain;
using Repository.Infrastructure.Repositories;
using RepositorySample.Application;
using TechTalk.SpecFlow;
using static RepositorySample.Tests.TestHelper;

namespace RepositorySample.Tests
{
    [Binding]
    public class RepositorySteps
    {
        [Given(@"A GenericRepository")]
        public void GivenAGenericRepository()
        {
            var contextFake = Substitute.For<DbContext>();
            var customerRepository = new GenericRepository<Customer>(contextFake);
            Bag.CustomerRepository = customerRepository;
            Bag.ContextFake = contextFake;
        }
        
        [When(@"I call GetAll")]
        public void WhenICallGetAll()
        {

        }
        
        [Then(@"the result is a query of entities")]
        public void ThenTheResultIsAQueryOfEntities()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
