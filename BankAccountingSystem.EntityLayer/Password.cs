// <copyright file="Password.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.EntityLayer
{
    public class Password : BaseEntity
    {
        public int CustomerId { get; set; }

        public string PasswordText { get; set; }
    }
}
