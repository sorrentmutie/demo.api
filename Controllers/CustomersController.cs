using demo.core.interfaces;
using demo.core.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IWelcome welcome;

        public CustomersController(IWelcome welcome)
        {
            this.welcome = welcome;
        }


        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(ExtractData());
        }

        private  List<Customer> ExtractData()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Mario Rossi " + welcome.SayHello(), City = "Naples" },
                new Customer { Id = 2, Name = "Luigi Bianchi", City = "Milano" }
            };
        }
    }
}
