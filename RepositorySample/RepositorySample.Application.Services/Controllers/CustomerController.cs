using System.Web.Mvc;
using RepositorySample.Configuration.Factories;

namespace RepositorySample.Application.Services.Controllers
{
    public class CustomerController : Controller
    {
        public ICustomerManager Manager { get; set; }

        // GET: Costumer
        public CustomerController()
        {
            Manager = Factory.Get<CustomerManager>();
        }

        public JsonResult Index()
        {
            var customers = Manager.GetAllActive();
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}