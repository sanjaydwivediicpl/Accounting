// <copyright file="ProofType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BankAccountingSystem.EntityLayer
{
    public class ProofType : BaseEntity
    {
        public int CustomerId { get; set; }

        public string ProofTypeName { get; set; }

        public string ProofTypeNo { get; set; }

        public bool Validated { get; set; }

        public string Reason { get; set; }
    }
}
