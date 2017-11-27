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

        public IEnumerable<Customer> List()
        {
            return this.dbContext.Customers.ToList();
        }
    }
}
