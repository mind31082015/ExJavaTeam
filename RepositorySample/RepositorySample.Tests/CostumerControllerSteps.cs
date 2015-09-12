using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NSubstitute;
using NUnit.Framework;
using Repository.Domain;
using RepositorySample.Application;
using RepositorySample.Application.Services.Controllers;
using TechTalk.SpecFlow;
using static RepositorySample.Tests.TestHelper;

namespace RepositorySample.Tests
{
    [Binding]
    public class CostumerControllerSteps
    {
        [Given(@"a CustomerController")]
        public void GivenACustomerController()
        {
            var customerController = new CustomerController();
            customerController.Manager = Substitute.For<ICustomerManager>();
            customerController.Manager.GetAllActive().Returns(new List<Customer>().AsQueryable());
            Bag.CustomerController = customerController;
        }
        
        [When(@"I call Index")]
        public void WhenICallIndex()
        {
            var customerController = Bag.CustomerController as CustomerController;
            var result = customerController.Index();
            Bag.Result = result;
        }
        
        [Then(@"the result is a list of active customers")]
        public void ThenTheResultIsAListOfActiveCustomers()
        {
            var result = Bag.Result;
            Assert.IsInstanceOf(typeof(JsonResult), result);
        }
    }
}
