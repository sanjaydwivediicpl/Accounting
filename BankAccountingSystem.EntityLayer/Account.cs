// <copyright file="Account.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.EntityLayer
{
    public class Account : BaseEntity
    {
        public int AccountNo { get; set; }

        public int CustomerId { get; set; }

        public int BranchId { get; set; }
    }
}
