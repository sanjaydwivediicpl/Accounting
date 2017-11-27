namespace BankAccountingSystem.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BankAccountingSystem.EntityLayer;
    using BankAccountingSystem.RepositoryLayer;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public ValuesController(ICustomerRepository customer)
        {
            this.customerRepository = customer;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return this.customerRepository.List();
                ////new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
