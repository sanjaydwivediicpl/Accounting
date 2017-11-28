namespace BankAccountingSystem.WebApi.Controllers
{
    using System.Collections.Generic;
    using BankAccountingSystem.EntityLayer;
    using BankAccountingSystem.RepositoryLayer;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customer)
        {
            this.customerRepository = customer;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return this.customerRepository.List();
        }

        [HttpPost]
        public int Post(Customer customer)
        {
            return this.customerRepository.Create(customer);
        }

        [HttpPut]
        public int Put(Customer customer)
        {
            return this.customerRepository.Update(customer);
        }

        [HttpDelete]
        public int Delete(Customer customer)
        {
            return this.customerRepository.Delete(customer);
        }
    }
}