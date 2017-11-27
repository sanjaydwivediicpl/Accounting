// <copyright file="ICustomerRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.RepositoryLayer
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BankAccountingSystem.EntityLayer;

    public interface ICustomerRepository
    {
        IEnumerable<Customer> List();
    }
}
