using BankAccountingSystem.DataAccessLayer;
using BankAccountingSystem.EntityLayer;
using System;
using System.Threading.Tasks;

namespace BankAccountingSystem.RepositoryLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankDbContext _dbContext;
        public CustomerRepository()
        {

        }
        public async Task<Customer> List()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICustomerRepository
    {
        Task<Customer> List();
    }
}
