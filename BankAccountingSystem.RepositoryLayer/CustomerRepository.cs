// <copyright file="CustomerRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.RepositoryLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BankAccountingSystem.DataAccessLayer;
    using BankAccountingSystem.EntityLayer;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankDbContext dbContext;

        public CustomerRepository(BankDbContext context)
        {
            this.dbContext = context;
        }

        public int Create(Customer customer)
        {
            int returnValue= Convert.ToInt32(this.dbContext.Customers.Add(customer).State);
            this.dbContext.SaveChanges();
            return returnValue;
        }

        public int Delete(Customer customer)
        {
            int returnValue = Convert.ToInt32(this.dbContext.Customers.Remove(customer).State);
            this.dbContext.SaveChanges();
            return returnValue;
        }

        public IEnumerable<Customer> List()
        {
            return this.dbContext.Customers.ToList();
        }

        public int Update(Customer customer)
        {
            int returnValue = Convert.ToInt32(this.dbContext.Customers.Update(customer).State);
            this.dbContext.SaveChanges();
            return returnValue;
        }
    }
}
