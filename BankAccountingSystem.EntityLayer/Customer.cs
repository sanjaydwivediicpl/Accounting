// <copyright file="Customer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.EntityLayer
{
    public class Customer: BaseEntity
    {
        public string FullName { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

        public int AccountTypeId { get; set; }

        public int AddressId { get; set; }

        public int AccountId { get; set; }
    }
}
